using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;

namespace MegaDesk_3_PattiJones
{
    public class DeskQuote
    {
        public Desk Desk { get; set; }
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public double TotalCost { get; set; }
        public Delivery DeskQuoteDelivery { get; set; }

        public enum Delivery
        {
            [Description("3")]
            threeDays = 3,
            [Description("5")]
            fiveDays = 5,
            [Description("7")]
            sevenDays = 7,
            [Description("14")]
            fourteenDays = 14,
        }

        //Default Constructor
        public DeskQuote()
        {
            Desk = new Desk();
            CustomerName = " ";
            QuoteDate = DateTime.Now;
            TotalCost = 0;
            DeskQuoteDelivery = DeskQuote.Delivery.fourteenDays;
        }

        //Non-Default Constructor
        public DeskQuote(Desk desk, string CustomerName, DateTime QuoteDate,
            int TotalCost, Delivery DeskQuoteDelivery)
        {
            this.Desk = desk;
            this.CustomerName = CustomerName;
            this.QuoteDate = QuoteDate;
            this.TotalCost = TotalCost;
            this.DeskQuoteDelivery = DeskQuote.Delivery.fourteenDays;
        }

        //GetSurfaceArea calculates the surface area of the desk
        public double getSurfaceArea()
        {
            //calculates the surface area of the desk
            int surfaceArea = Desk.Width * Desk.Depth;

            //calculate if surface area is bigger than 1000 in2 and add $1 per in2
            double addSurfaceCost = 0.00;
            if (surfaceArea > 1000)
            {
                double inches = surfaceArea - 1000;
                addSurfaceCost = inches * 1.00;
            }
       
            return surfaceArea;
        }

        //GetDeliveryCost calculates the delivery depending on amount of days
        public double getDeliveryCost()
        {
            double rushDeliveryCost = 0.00;
            switch (DeskQuoteDelivery)
            {
                case DeskQuote.Delivery.threeDays:
                    if (getSurfaceArea() >= 1000 & getSurfaceArea() <= 2000)
                        rushDeliveryCost = 70.00;
                    else if (getSurfaceArea() > 2000)
                        rushDeliveryCost = 80.00;
                    else
                        rushDeliveryCost = 60.00;
                    break;
                case DeskQuote.Delivery.fiveDays:
                    if (getSurfaceArea() >= 1000 & getSurfaceArea() <= 2000)
                        rushDeliveryCost = 50.00;
                    else if (getSurfaceArea() > 2000)
                        rushDeliveryCost = 60.00;
                    else
                        rushDeliveryCost = 40.00;
                    break;
                case DeskQuote.Delivery.sevenDays:
                    if (getSurfaceArea() >= 1000 & getSurfaceArea() <= 2000)
                        rushDeliveryCost = 35.00;
                    else if (getSurfaceArea() > 2000)
                        rushDeliveryCost = 40.00;
                    else
                        rushDeliveryCost = 30.00;
                    break;
                case DeskQuote.Delivery.fourteenDays:
                    rushDeliveryCost = 0.00;
                    break;
            }

            return rushDeliveryCost;
        }

        //GetMaterialCost calculates the cost per material type
        public double getMaterialCost()
        {
            double surfaceMaterialCost;
            switch (Desk.DeskMaterial)
            {
                case Desk.Material.Oak:
                    surfaceMaterialCost = 200.00;
                    break;

                case Desk.Material.Laminate:
                    surfaceMaterialCost = 100.00;
                    break;
                case Desk.Material.Pine:
                    surfaceMaterialCost = 50.00;
                    break;
                case Desk.Material.Rosewood:
                    surfaceMaterialCost = 300.00;
                    break;
                case Desk.Material.Veneer:
                    surfaceMaterialCost = 125.00;
                    break;
                default:
                    surfaceMaterialCost = 0.00;
                    break;
            }

            return surfaceMaterialCost;
        }

        //GetDrawersCost calculates the cost per drawer
        public double getDrawersCost()
        {
            //Price per drawer
            double drawersCost = Desk.Drawers * 50.00;

            return drawersCost;
        }

        //GetTotalCost calculates the price of the desk with delivery
        public double getTotalCost()
        {
            double basePrice = 200.00;
            TotalCost = basePrice + getSurfaceArea() + getDeliveryCost() + getMaterialCost() + getDrawersCost();
            this.TotalCost = TotalCost;
            return TotalCost;
        }
    }
}
