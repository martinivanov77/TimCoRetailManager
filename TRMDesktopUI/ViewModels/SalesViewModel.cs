using Caliburn.Micro;
using System;
using System.ComponentModel;
using System.Threading.Tasks;


namespace TRMDesktopUI.ViewModels
{
   public class SalesViewModel : Screen
    {
        private BindingList<string> _products;
        private int _itemQuantity;

        public BindingList<string> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }
        private BindingList<string> _cart;

        public BindingList<string> Cart
        {
            get { return _cart; }
            set
            {
                _cart = value;
                NotifyOfPropertyChange(() => Cart);
            }
        }
        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set
            {
                _itemQuantity = value;
                NotifyOfPropertyChange(() => ItemQuantity);
            }
        }
        public string SubTotal
        {
            //TODO : Replace with calculation
            get { return "$0.00"; }
        }
        public string Total
        {
            //TODO : Replace with calculation
            get { return "$0.00"; }
        }
        public string Tax
        {
            //TODO : Replace with calculation
            get { return "$0.00"; }
        }

        public bool CanAddToCart
        {
            get
            {
                bool output = false;
                //make sure something is selected
                //make sure there is an item quantity

                return output;
            }
        }
        public void AddToCart()
        {

        }

        public bool CanRemoveFromCart
        {
            get
            {
                bool output = false;
                //make sure something is selected

                return output;
            }
        }
        public void RemoveFromCart()
        {

        }

        public bool CanCheckOut
        {
            get
            {
                bool output = false;
                //make sure something is in the cart

                return output;
            }
        }
        public void CheckOut()
        {

        }
    }
}
