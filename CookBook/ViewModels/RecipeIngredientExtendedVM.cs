using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.ViewModels
{
    public class RecipeIngredientExtendedVM:RecipeIngredientVM
    {
        public decimal MissingAmount { get; set; }

        public string NameWithMissingAmount
        {
            get 
            {
                if(MissingAmount !=0)
                    return NameWithAmount + " Missing (" + (int)MissingAmount + "g)";

                return NameWithAmount;
            }
        }

        public RecipeIngredientExtendedVM(int ingredientId, string name, decimal amount, decimal missingAmount):base(ingredientId, name, amount)
        {
            MissingAmount=missingAmount;
        }
    }
}
