﻿namespace Module.Sales.Common
{
    public static class Permissions
    {
        public const string CustomerCreate = "sales.customer.create";
        public const string CustomerUpdate = "sales.customer.update";
        public const string CustomerView = "sales.customer.view";
        public const string CustomerDelete = "sales.customer.delete";
        public const string CustomerList = "sales.customer.list";
        public const string CustomerManage = "sales.customer.manage";

        public const string InvoiceCreate = "sales.invoice.create";
        public const string InvoiceUpdate = "sales.invoice.update";
        public const string InvoiceView = "sales.invoice.view";
        public const string InvoiceDelete = "sales.invoice.delete";
        public const string InvoiceList = "sales.invoice.list";
        public const string InvoiceManage = "sales.invoice.manage";

        public const string ProductCreate = "sales.product.create";
        public const string ProductUpdate = "sales.product.update";
        public const string ProductView = "sales.product.view";
        public const string ProductDelete = "sales.product.delete";
        public const string ProductList = "sales.product.list";
        public const string ProductManage = "sales.product.manage";

        public const string InvoicePaymentCreate = "sales.invoice.payment.create";
        public const string InvoicePaymentUpdate = "sales.invoice.payment.update";
        public const string InvoicePaymentView = "sales.invoice.payment.view";
        public const string InvoicePaymentDelete = "sales.invoice.payment.delete";
        public const string InvoicePaymentList = "sales.invoice.payment.list";
        public const string InvoicePaymentManage = "sales.invoice.payment.manage";

        public const string VendorCreate = "sales.vendor.create";
        public const string VendorUpdate = "sales.vendor.update";
        public const string VendorView = "sales.vendor.view";
        public const string VendorDelete = "sales.vendor.delete";
        public const string VendorList = "sales.vendor.list";
        public const string VendorManage = "sales.vendor.manage";

        public const string QouteCreate = "sales.qoute.create";
        public const string QouteUpdate = "sales.qoute.update";
        public const string QouteView = "sales.qoute.view";
        public const string QouteDelete = "sales.qoute.delete";
        public const string QouteList = "sales.qoute.list";
        public const string QouteManage = "sales.qoute.manage";

        public const string BillCreate = "sales.bill.create";
        public const string BillUpdate = "sales.bill.update";
        public const string BillView = "sales.bill.view";
        public const string BillDelete = "sales.bill.delete";
        public const string BillList = "sales.bill.list";
        public const string BillManage = "sales.bill.manage";

        public const string ChartOfAccountCreate = "accounting.chartofaccount.create";
        public const string ChartOfAccountUpdate = "accounting.chartofaccount.update";
        public const string ChartOfAccountView = "accounting.chartofaccount.view";
        public const string ChartOfAccountDelete = "accounting.chartofaccount.delete";
        public const string ChartOfAccountList = "accounting.chartofaccount.list";
        public const string ChartOfAccountManage = "accounting.chartofaccount.manage";

        public const string ChartOfAccountCategoryCreate = "accounting.chartofaccount.category.create";
        public const string ChartOfAccountCategoryUpdate = "accounting.chartofaccount.category.update";
        public const string ChartOfAccountCategoryView = "accounting.chartofaccount.category.view";
        public const string ChartOfAccountCategoryDelete = "accounting.chartofaccount.category.delete";
        public const string ChartOfAccountCategoryList = "accounting.chartofaccount.category.list";
        public const string ChartOfAccountCategoryManage = "accounting.chartofaccount.category.manage";

        public const string TransactionCreate = "accounting.transaction.create";
        public const string TransactionUpdate = "accounting.transaction.update";
        public const string TransactionView = "accounting.transaction.view";
        public const string TransactionDelete = "accounting.transaction.delete";
        public const string TransactionList = "accounting.transaction.list";
        public const string TransactionManage = "accounting.transaction.manage";

        public const string PaymentCreate = "payments.create";
        public const string PaymentUpdate = "payments.update";
        public const string PaymentView = "payments.view";
        public const string PaymentDelete = "payments.delete";
        public const string PaymentList = "payments.list";
        public const string PaymentManage = "payments.manage";

        public static class Group
        {
            public const string Customer = "Customer";
            public const string Invoice = "Invoice";
            public const string InvoicePayment = "Invoice Payment";
            public const string Product = "Product";
            public const string Vendor = "Vendor";
            public const string Quote = "Quote";
            public const string Bill = "Bill";
            public const string ChartOfAccount = "Chart Of Account";
            public const string ChartOfAccountCategory = "Chart Of Account Category";
            public const string Transaction = "Transaction";
            public const string Payment = "Payment";
        }
    }
}
