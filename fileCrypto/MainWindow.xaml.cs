using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace fileCrypto
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, RoutedEventArgs e)
        {
            Encrypt(txtEncryptPath.Text, txtEncryptKey.Text);
        }
        private async void Encrypt(string path, string key)
        {
            await Task.Run(() =>
            {
                //create a new Crypto element
                try
                {
                    //read file to get the content
                    string content = File.ReadAllText(path);
                    Crypto crypto = new Crypto(content, int.Parse(key));
                    string toWrite = crypto.Encrypt();
                    WriteFile(path + ".bin", toWrite);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }

        private async void WriteFile(string path, string content)
        {
            await Task.Run(() =>
            {
                try
                {
                    
                    Byte[] write = System.Text.Encoding.ASCII.GetBytes(content);
                    File.WriteAllBytes(path, write);
                    
                    MessageBox.Show("the file has been successfully encrypted, you can find it in " + path);
                }
                catch (Exception ex)
                {
                    WriteFile(path, content); //try to write file since I write it
                }
            });
        }
        private string ReadFile(string path)
        {
            Byte[] b = File.ReadAllBytes(path);
            string content = System.Text.Encoding.ASCII.GetString(b);
            return content;
            
        }

        private void btnDecrypt_Click(object sender, RoutedEventArgs e)
        {
            Decrypt(txtDecryptPath.Text, txtDecryptKey.Text);
        }
        private async void Decrypt(string path, string key)
        {
            await Task.Run(() =>
            {
                try
                {
                    //read file to get the content

                    string content = ReadFile(path);

                    Crypto crypto = new Crypto(content, int.Parse(key));

                    string toWrite = crypto.Decrypt();

                    //WriteFile(DeleteBin(txtDecryptPath.Text), toWrite);
                    path = DeleteBin(path);
                    File.WriteAllText(path, toWrite);
                    MessageBox.Show("the file has been successfully decrypted, you can find it in " + path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }

        private string DeleteBin(string path)
        {
            if (path.Contains(".bin"))
            {
                string[] p = path.Split('.');
                string ret = "";
                for(int i = 0; i < p.Length; i++)
                {
                    if(i != p.Length-1)
                    {
                        if(i == p.Length-2)
                        {
                            //there is no '.' at the end
                            ret += p[i];
                        }
                        else
                        {
                            ret += p[i] + ".";
                        }
                        
                    }
                }
                return ret;
            }
            else
            {
                throw new Exception("this is not a file encrypte with this app");
            }
            
        }
    }
}
