using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace Encrypt_Decrypt_Data.Models
{
    public class CardModel
    {
        /*********************************************************************/
        /************************ Begin of Properties ************************/
        /*********************************************************************/       
        

        //[Required(ErrorMessage = "Please enter correct credit card format.")]
        //[RegularExpression(@"\b(?:4[0-9]{12}(?:[0-9]{3})?|5[12345][0-9]{14}|3[47][0-9]{13}|3(?:0[012345]|[68][0-9])[0-9]{11}|6(?:011|5[0-9]{2})[0-9]{12}|(?:2131|1800|35[0-9]{3})[0-9]{11})\b", ErrorMessage = "Please enter correct credit card format (16-digits, no spaces)")]
        //[StringLength(19, ErrorMessage = "Credit Card Number should not be more than 16 digit.")]
        //// [RegularExpression(@"^(\d)$", ErrorMessage = "Invalid Card Number.")]
        //[Display(Name = "Credit Card Number:")]
        //public string card { get; set; }

        [Required(ErrorMessage = "Please enter correct credit card format.")]
        [RegularExpression(@"\b(?:4[0-9]{12}(?:[0-9]{3})?|5[12345][0-9]{14}|3[47][0-9]{13}|3(?:0[012345]|[68][0-9])[0-9]{11}|6(?:011|5[0-9]{2})[0-9]{12}|(?:2131|1800|35[0-9]{3})[0-9]{11})\b", ErrorMessage = "Please enter correct credit card format (16-digits, no spaces)")]
        [StringLength(19, ErrorMessage = "Credit Card Number should not be more than 19 digits.")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Card expiration month is required")]
        public string ExpMonth { get; set; }

        [Required(ErrorMessage = "Card expiration year is required")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Invalid Year")]
        [StringLength(4,ErrorMessage="Invalid Year")]
        public string ExpYear { get; set; }

        //[RegularExpression(@"^[0-9]+$", ErrorMessage = "Invalid CVV Code")]
        //[Required(ErrorMessage = "Security code is required")]
        //[StringLength(5, ErrorMessage = "Should not be more than 5 digits")]
        public string CVVCode { get; set; }


        /*********************************************************************/
        /************************ End of Properties **************************/
        /*********************************************************************/

        public static List<SelectListItem> GetMonthList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem() { Text = "Select Month*", Value = "" });
            list.Add(new SelectListItem() { Text = "January", Value = "01" });
            list.Add(new SelectListItem() { Text = "February", Value = "02" });
            list.Add(new SelectListItem() { Text = "March", Value = "03" });
            list.Add(new SelectListItem() { Text = "April", Value = "04" });
            list.Add(new SelectListItem() { Text = "May", Value = "05" });
            list.Add(new SelectListItem() { Text = "June", Value = "06" });
            list.Add(new SelectListItem() { Text = "July", Value = "07" });
            list.Add(new SelectListItem() { Text = "August", Value = "08" });
            list.Add(new SelectListItem() { Text = "September", Value = "09" });
            list.Add(new SelectListItem() { Text = "October", Value = "10" });
            list.Add(new SelectListItem() { Text = "November", Value = "11" });
            list.Add(new SelectListItem() { Text = "December", Value = "12" });
            return list;
        }
        public static List<SelectListItem> GetYearList()
        {
            System.Globalization.TextInfo ti = System.Globalization.CultureInfo.CurrentCulture.TextInfo;

            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem() { Text = "Select Year*", Value = "" });

            try
            {
                for (int i = DateTime.Now.Year -1 ; i <= 2025; i++)                
                {
                    list.Add(new SelectListItem() { Text = i.ToString(), Value = i.ToString() });
                }
            }
            catch (Exception)
            { }

            return list;
        }


    }


    public class EncryptedCard
    {
        public string CardNumber { get; set; }
        public string ExpMonth { get; set; }
        public string ExpYear { get; set; }

    }
}