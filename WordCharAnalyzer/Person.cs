using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCharAnalyzer
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public string NationalCode { get; set; }
        public string Gender { get; set; }
        public OperationResult ValidateInput()
        {
            bool isNameValid = string.IsNullOrWhiteSpace(FirstName);
            bool isLastNameValid = string.IsNullOrWhiteSpace(LasttName);
            var isNationalCodeValid = NationalCode.IsValidNationalCode();
            bool isGenderValid = string.IsNullOrWhiteSpace(Gender);

            if (isNameValid)
            {
                return new OperationResult
                {
                    IsSuccess = false,
                    Message= "لطفا نام خود را وارد کنید"
                }; 
            }
            if (isLastNameValid)
            {
                return new OperationResult
                {
                    IsSuccess = false,
                    Message = " لطفا نام خانوادگی خود را وارد کنید"
                };
            }
            if (!isNationalCodeValid.IsSuccess)
            {
                return new OperationResult
                {
                    IsSuccess = false,
                    Message = isNationalCodeValid.Message
                };
            }
            if (isGenderValid)
            {
                return new OperationResult
                {
                    IsSuccess = false,
                    Message = " لطفا جنسیت خود را انتخاب کنید"
                };
            }
            return new OperationResult
            {
                IsSuccess = true
            };
        }


    }
}
