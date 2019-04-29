using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Form
{
    public class currentItem //current item class
    {
        private string resourceType;
        private string resourceName;
        private int quantity;
        private int maxLoanPeriod;
        private string supplierSource;
        private decimal purchasePrice;
        private long serialNumber;
        private string department;
        private string disposalDate;
        private string methodOfDisposal;
        private string disposedBy;
        private string notes;
        private string dateAdded;
        private int itemID;
        private int total;
        private string addedBy;
        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }
        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        public string ResourceType
        {
            get { return resourceType; }
            set { resourceType = value; }
        }
        public string AddedBy
        {
            get { return addedBy; }
            set { addedBy = value; }
        }
        public string ResourceName
        {
            get { return resourceName; }
            set { resourceName = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int MaxLoanPeriod
        {
            get { return maxLoanPeriod; }
            set { maxLoanPeriod = value; }
        }
        public string SupplierSource
        {
            get { return supplierSource; }
            set { supplierSource = value; }
        }
        public decimal PurchasePrice
        {
            get { return purchasePrice; }
            set { purchasePrice = value; }
        }
        public long SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public string DisposalDate
        {
            get { return disposalDate; }
            set { disposalDate = value; }
        }
        public string MethodOfDisposal
        {
            get { return methodOfDisposal; }
            set { methodOfDisposal = value; }
        }
        public string DisposedBy
        {
            get { return disposedBy; }
            set { disposedBy = value; }
        }
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }
        public string DateAdded
        {
            get { return dateAdded; }
            set { dateAdded = value; }
        }
    }
}
