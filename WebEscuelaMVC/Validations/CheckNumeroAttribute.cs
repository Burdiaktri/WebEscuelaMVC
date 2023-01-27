using System.ComponentModel.DataAnnotations;

namespace WebEscuelaMVC.Validations
{
    public class CheckNumeroAttribute : ValidationAttribute
    {
        public CheckNumeroAttribute() {
            ErrorMessage = "El número debe ser mayor a 100";
        }

        public override bool IsValid(object value)
        {
            int numero = (int)value;
            if(numero < 100)
            {
                return false;

            }
            return true;
        }
    }
}
