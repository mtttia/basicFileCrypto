   M S B A M L   `   `   `  ����E  AfileCrypto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:fileCrypto
fileCrypto  5   	       fileCrypto.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:fileCrypto     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   � $
��Left=�6   $	��399��6*   $��	10,10,0,0q�67   $	��Top=�6J   $	��366��6b   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ White��6#    � Offset$ 0Q�61   � 5      $ 	#FFFFF74B��6#   $ 1Q�65   5      .+�5      �� $��Encrypt��6   $
��Left=�6&   $��86��6A   $��	43,10,0,0q�6M   $	��Top=�6`   $	��291��6x   $��48(�6�   $��Segoe Print)�6�   �� 5      $����Select a file to encrypt with this app. 
Warning: Once the file is encrypted, do not change it to 
anyone so as not to compromise decryption.��6   $
��Left=�6�   $��62��6�   $��
10,101,0,0q�6�   $	��Top=�6�   $	��346��6  �� 5      -   5         ��Name$ txtEncryptPath��5      $
��Left=�6.   $��30��6I   $��
10,212,0,0q�6U    �� TextWrapping$
 Wrap=�6i   $	��Top=�6}   $	��346��6�   �� 5      $%��Write here file to encrypt path��6   $
��Left=�6>   $��31��6Y   $��
10,176,0,0q�6e   $	��Top=�6y   $	��346��6�   �� 5      -   5         ��Name$ 
btnEncrypt��5      $��Encrypt��6)   $
��Left=�6;   $��36��6V   $��225,353,0,0q�6b   $	��Top=�6w   $	��131��6�   $��20(�6�   6�   �� 5      -   5        $ txtEncryptKey��5      $
��Left=�6-   $��30��6H   $��
10,318,0,0q�6T   $
 Wrap=�6h   $	��Top=�6|   $	��346��6�   �� 5      $���}Insert a key
WARNING : don't forgot the key, without the key you can't 
decrypt the file. You can see the key as a password��6   $
��Left=�6�   $��66��6�   $��
10,247,0,0q�6�   $	��Top=�6�   $	��346��6�   5      � 5   
   $
��Left=�6   $	��399��6*   $��
403,10,0,0q�67   $	��Top=�6K   $	��379��6c   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FFFFF74B��6#   $ 0Q�65   � 5      $ White��6#   $ 1Q�61   5      .+�5!      �� $��Decrypt��6   $
��Left=�6&   $��86��6A   $��	64,10,0,0q�6M   $	��Top=�6`   $	��291��6x   $��48(�6�   $��Segoe Print)�6�   �� 5"      $h��bSelect an encrypted file with this app. 
Warning : The file must not have been edited in any way.��6   $
��Left=�6�   $��62��6�   $��
10,101,0,0q�6�   $	��Top=�6�   $	��346��6�   �� 5#      -   5        $ txtDecryptPath��5#      $
��Left=�6.   $��30��6I   $��
10,212,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $	��346��6�   �� 5$      $%��Write here file to decrypt path��6   $
��Left=�6>   $��31��6Y   $��
10,176,0,0q�6e   $	��Top=�6y   $	��346��6�   �� 5%      -   5        $ 
btnDecrypt��5%      $��Decrypt��6)   $
��Left=�6;   $��36��6V   $��225,353,0,0q�6b   $	��Top=�6w   $	��131��6�   $��20(�6�   6�   �� 5&      -   5        $ txtDecryptKey��5&      $
��Left=�6-   $��30��6H   $��
10,318,0,0q�6T   $
 Wrap=�6h   $	��Top=�6|   $	��346��6�   �� 5'      $5��/Enter the key with which you encrypted the file��6   $
��Left=�6N   $��31��6i   $��
10,247,0,0q�6u   $	��Top=�6�   $	��346��6�   5(      5,      5-      