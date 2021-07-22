using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slotkin_P3
{
    class LogoOrderItem
    {
        private bool _hasLogo; 
        public bool HasLogo
        {
            get {return _hasLogo;}
            set{_hasLogo = value; Calc();}
        }

        private string _itemType;
        public string ItemType
        {
            get {return _itemType;}
            set {_itemType = value; Calc();}
        }

        private int _numColors;
        public int NumColors
        {
            get {return _numColors;}
            set {_numColors = value; Calc();}
        }

        private int _numItems;
        public int NumItems
        {
            get {return _numItems;}
            set { _numItems = value; Calc();}
        }

        private string _text;
        public string Text
        {
            get { return _text;}
            set { _text = value; Calc(); }
        }

        public int ItemID { get; set; }

        private double price;
        public double Price 
        {
            get { return price; }
        } 

        public LogoOrderItem(bool newHasLogo, string newItemType, int newNumColors, int newNumItems, 
            string newText, int newItemID)
        {
            this.HasLogo = newHasLogo;
            this.ItemType = newItemType;
            this.NumColors = newNumColors;
            this.NumItems = newNumItems;
            this.Text = newText;
            this.ItemID = newItemID;
        }

        public LogoOrderItem(bool newHasLogo, string newText) : this(newHasLogo, "coffee mug(s)", 0, 0, newText, -1 )
        {
        }

        public LogoOrderItem() : this(false, "coffee mug(s)", 0, 0, "", -1)
        {
        }

        private void Calc()
        {
            const double costOfPen = 1.00;
            const double costOfCoffeeMug = 3.50;
            const double costOfUsbDriver = 4.00;
            double costOfText = 0.00;
            double costOfGraphicLogo = 0.00;
            double costOfEachColorInColorLogo = 0.00;

            void logoCost()
            {
                if (Text != "")
                {
                    costOfText = 0.05;
                }

                if (HasLogo == true)
                {
                    costOfGraphicLogo = 0.10;

                    if (NumColors != 0)
                    {
                        costOfEachColorInColorLogo = 0.03;
                    }
                }
            }

            if (ItemType == "pen(s)")
            {
                logoCost();

                this.price = ((NumItems * costOfPen) + (NumItems * costOfText) + (NumItems * costOfGraphicLogo)
                    + ((NumColors * costOfEachColorInColorLogo) * NumItems));         
            }
            else if (ItemType == "coffee mug(s)")
            {
                logoCost();

                this.price = ((NumItems * costOfCoffeeMug) + (NumItems * costOfText) + (NumItems * costOfGraphicLogo)
                    + ((NumColors * costOfEachColorInColorLogo) * NumItems));
            }
            else if (ItemType == "usb driver(s)")
            {
                logoCost();

                this.price = ((NumItems * costOfUsbDriver) + (NumItems * costOfText) + (NumItems * costOfGraphicLogo)
                    + ((NumColors * costOfEachColorInColorLogo) * NumItems));
            }
        }

        public string GetOrderSummary()  
        {
            string orderSummary = "Order Number: "+ItemID+"\r\n"+NumItems+" "+ItemType+" with "+NumColors+" logo colors selected.\r\n" +
                "Text to be displayed: "+Text+"\r\n~~QUOTED PRICE: $"+Price+".";
            return orderSummary;
        }
    }
}
