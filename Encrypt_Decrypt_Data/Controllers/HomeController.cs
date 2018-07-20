using Encrypt_Decrypt_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Encrypt_Decrypt_Data.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }
        
        public ActionResult EncryptValue()
        {
            if (Request.Params["m"] != null)
            {
                if (Request.Params["m"].ToString() == "1")
                {
                    ViewBag.upmessage = "Card details Encrypted Successfully!";
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult EncryptValue(CardModel model)
        {
            //SecurityKey can be any unique key which is used to Encrypt and Decript a value. 
            //You will have to pass this SecurityKey along with the text you want to Cipher.
            //SecurityKey can be customer's any unique value, for example: userId/CustomerGUID/Email etc.
            string SecurityKey = "9898jdhjd7";//(passPhrase) value


            string CardNumber, ExpMonth, ExpYear = "";

            CardNumber = StringCipher.Encrypt(model.CardNumber, SecurityKey);
            ExpMonth = StringCipher.Encrypt(model.ExpMonth, SecurityKey);
            ExpYear = StringCipher.Encrypt(model.ExpYear, SecurityKey);


            ViewBag.CardNumber = CardNumber;
            ViewBag.ExpMonth = ExpMonth;
            ViewBag.ExpYear = ExpYear;


            return View();
        }

        public ActionResult DecryptValue()
        {
            EncryptedCard model = new EncryptedCard();

            //Here I am using a static values which is encrypted.
            //CardNumber: 4111111111111111
            //Expiry Month: 01
            //Expiry Year: 2020

            model.CardNumber = "+rBrMbWjMOr44M0dvmiOZutqllU+iCFNDTW25Gi1PRs="; 
            model.ExpMonth = "6px2VegSl2OFtT9CIGaETQ==";
            model.ExpYear = "PF+aUcgj/KiQlBI9ahz6EQ==";

            return View(model);
        }

        [HttpPost]
        public ActionResult DecryptValue(EncryptedCard model)
        {
            //SecurityKey can be any unique key which is used to Encrypt and Decript a value. 
            //You will have to pass this SecurityKey along with the text you want to Cipher.
            //SecurityKey can be customer's any unique value, for example: userId/CustomerGUID/Email etc.
            string SecurityKey = "9898jdhjd7";//(passPhrase) value

            string DecryptedCardNumber = StringCipher.Decrypt(model.CardNumber, SecurityKey);
            string DecryptedExpMonth = StringCipher.Decrypt(model.ExpMonth, SecurityKey);
            string DecryptedExpYear = StringCipher.Decrypt(model.ExpYear, SecurityKey);


            ViewBag.DecryptedCardNumber = DecryptedCardNumber;
            ViewBag.DecryptedExpMonth = DecryptedExpMonth;
            ViewBag.DecryptedExpYear = DecryptedExpYear;

            return View();
        }


    }
}