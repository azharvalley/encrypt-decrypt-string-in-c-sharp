# encrypt-decrypt-string-in-c-sharp

Encrypt and Decrypt a string in C#
===============================================

We are using StringCipher class file.

Rijndael algorithm is used in StringCipher class for Encryption and Decryption.

1. In StringCipher.cs file replace initVectorBytes value with your unique key.

// private static readonly byte[] initVectorBytes = Encoding.ASCII.GetBytes("YOUR UNIQUE KEY");

2. Use a unique value (passPhrase) for each Encrytion and Decription, (passPhrase) is a kind of password which is used to Encrypt and Decrypt. You must use same (passPhrase) value to Decipher a text which was used to Cipher.

// StringCipher.Encrypt("textToCipher", "UNIQUE PASSWORD");

// StringCipher.Decrypt("textToDecipher", "UNIQUE PASSWORD");

====================================================

--> SecurityKey can be any unique key which is used to Encrypt and Decript a value. 

--> You will have to pass this SecurityKey along with the text you want to Cipher.

--> SecurityKey can be customer's any unique value, for example: userId/CustomerGUID/Email etc.



/*Author of StringCipher.cs: http://stackoverflow.com/questions/10168240/encrypting-decrypting-a-string-in-c-sharp */
