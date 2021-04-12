﻿using Module.Systems.Entities;
using Msi.Data.Entity;
using System;
using System.Collections.Generic;

namespace Module.Systems.Domain
{
    public class CurrencySeeds : ISeed<Currency>
    {
        public int Order => 0;

        public IEnumerable<Currency> GetSeeds()
        {
            return new List<Currency>
            {
                new Currency { Id = Guid.Parse("63f4c8dc-6863-4971-8066-3aca28af142e"), Name = "UAE dirham", Code3 = "AED", Symbol = "AED", Plural = "UAE dirhams" },
                new Currency { Id = Guid.Parse("ec56bd2a-a134-495c-9708-bace3aa8e710"), Name = "Afghani", Code3 = "AFN", Symbol = "؋", Plural = "Afganis" },
                new Currency { Id = Guid.Parse("840cc1e2-269b-482a-becb-a120586b8a33"), Name = "Lek", Code3 = "ALL", Symbol = "Lek", Plural = "Lekë" },
                new Currency { Id = Guid.Parse("c5ec4b94-6226-4d48-9ec8-3f87ce3e0d66"), Name = "Armenian dram", Code3 = "AMD", Symbol = "֏", Plural = "Armenian drams" },
                new Currency { Id = Guid.Parse("20804d96-c11f-4623-9961-6c57cd60597c"), Name = "Netherlands Antillean guilder", Code3 = "ANG", Symbol = "ƒ", Plural = "Netherlands Antillean guilders" },
                new Currency { Id = Guid.Parse("c0687019-d389-4dd3-84d4-404d305deb10"), Name = "Kwanza", Code3 = "AOA", Symbol = "Kz", Plural = "Kwanzas" },
                new Currency { Id = Guid.Parse("cd9eb67d-7254-47f7-8e1d-168653d04998"), Name = "Argentinian peso", Code3 = "ARS", Symbol = "$", Plural = "Argentinian pesos" },
                new Currency { Id = Guid.Parse("18e92f5d-82d6-4e41-a413-c113a8a5df2c"), Name = "Australian dollar", Code3 = "AUD", Symbol = "$", Plural = "Australian dollars" },
                new Currency { Id = Guid.Parse("c583ebda-3db2-46ce-8790-be51280f977c"), Name = "Aruban florin", Code3 = "AWG", Symbol = "ƒ", Plural = "Aruban florin" },
                new Currency { Id = Guid.Parse("cd8b67ab-06e2-4145-adb5-b18f3755cf30"), Name = "New Manat", Code3 = "AZN", Symbol = "ман", Plural = "New Manat" },
                new Currency { Id = Guid.Parse("40dd02af-9799-48a0-a87b-09d6ce16d7cf"), Name = "Convertible Marks", Code3 = "BAM", Symbol = "KM", Plural = "Convertible Marks" },
                new Currency { Id = Guid.Parse("b6e458a1-b515-435b-8408-125b05ea4e48"), Name = "Barbados dollar", Code3 = "BBD", Symbol = "$", Plural = "Barbados dollars" },
                new Currency { Id = Guid.Parse("6f902863-ba4f-44a5-8b94-c9d7080b8b7c"), Name = "Taka", Code3 = "BDT", Symbol = "৳", Plural = "Takas" },
                new Currency { Id = Guid.Parse("4b546137-30d9-481f-8290-d933bbcae452"), Name = "Lev", Code3 = "BGN", Symbol = "лв", Plural = "Leva" },
                new Currency { Id = Guid.Parse("eb4931ce-00f1-4cf8-b4b6-971591253a9f"), Name = "Bahraini dinar", Code3 = "BHD", Symbol = "BD", Plural = "Bahraini dinars" },
                new Currency { Id = Guid.Parse("55033a9e-671c-473d-96b6-67b8ad86f056"), Name = "Burundi franc", Code3 = "BIF", Symbol = "FBu", Plural = "Burundi francs" },
                new Currency { Id = Guid.Parse("5e47fcca-58e1-447e-9896-88c8920e9438"), Name = "Bermuda dollar", Code3 = "BMD", Symbol = "$", Plural = "Bermuda dollars" },
                new Currency { Id = Guid.Parse("2fb32292-c3d6-409e-a9d7-76fdd1d04093"), Name = "Brunei dollar", Code3 = "BND", Symbol = "$", Plural = "Brunei dollars" },
                new Currency { Id = Guid.Parse("852810b4-6794-4948-90e0-069f057eca21"), Name = "Boliviano", Code3 = "BOB", Symbol = "$b", Plural = "Bolivianos" },
                new Currency { Id = Guid.Parse("be88fc3b-4665-4ce6-b0b8-4f76071106d0"), Name = "Real", Code3 = "BRL", Symbol = "R$", Plural = "Reales" },
                new Currency { Id = Guid.Parse("aaac99d7-c2d2-418e-95db-53694bcf40c0"), Name = "Bahamian dollar", Code3 = "BSD", Symbol = "$", Plural = "Bahamian dollars" },
                new Currency { Id = Guid.Parse("8ccdf5ed-8166-4a3c-8a9b-69401127f735"), Name = "Ngultrum", Code3 = "BTN", Symbol = "Nu.", Plural = "Ngultrums" },
                new Currency { Id = Guid.Parse("1fcb8567-24de-466c-9bdd-c01b46a2caeb"), Name = "Pula", Code3 = "BWP", Symbol = "P", Plural = "Pula" },
                new Currency { Id = Guid.Parse("9e82904e-840a-42e0-b1f2-b2adb1851c4d"), Name = "Belarussian rouble", Code3 = "BYR", Symbol = "p.", Plural = "Belarussian roubles" },
                new Currency { Id = Guid.Parse("51089759-519b-474f-9e65-dac86c204769"), Name = "Belize dollar", Code3 = "BZD", Symbol = "BZ$", Plural = "Belize dollars" },
                new Currency { Id = Guid.Parse("1af1b8d6-be5d-437d-8bd4-08055203993b"), Name = "Canadian dollar", Code3 = "CAD", Symbol = "$", Plural = "Canadian dollars" },
                new Currency { Id = Guid.Parse("d5af2acd-dc1a-45bd-9517-98e82607e2ff"), Name = "Franc congolais", Code3 = "CDF", Symbol = "₣", Plural = "Francs congolais" },
                new Currency { Id = Guid.Parse("8712b274-59d3-4e70-bd63-70c95c50b7fc"), Name = "Swiss franc", Code3 = "CHF", Symbol = "CHF", Plural = "Swiss francs" },
                new Currency { Id = Guid.Parse("73b40d5e-5e36-439f-a6bd-9d09f2852ac3"), Name = "Chilean peso", Code3 = "CLP", Symbol = "$", Plural = "Chilean pesos" },
                new Currency { Id = Guid.Parse("d89f497d-e6c8-43ce-868a-9806af78d207"), Name = "Ren-Min-Bi yuan", Code3 = "CNY", Symbol = "¥", Plural = "Ren-Min-Bi yuan" },
                new Currency { Id = Guid.Parse("ffc33209-5e2e-4d4a-aeff-46af3944f563"), Name = "Colombian peso", Code3 = "COP", Symbol = "$", Plural = "Colombian pesos" },
                new Currency { Id = Guid.Parse("64e55e0e-618f-4ab8-b394-00eac916b6ec"), Name = "Costa Rican colon", Code3 = "CRC", Symbol = "₡", Plural = "Costa Rican colones" },
                new Currency { Id = Guid.Parse("624366be-fc32-4393-b7f5-e16ddd4fbbcb"), Name = "Cuban peso", Code3 = "CUP", Symbol = "₱", Plural = "Cuban pesos" },
                new Currency { Id = Guid.Parse("0268c118-585a-4df6-974a-1ba9db038130"), Name = "Cape Verde escudo", Code3 = "CVE", Symbol = "Esc", Plural = "Cape Verde escudos" },
                new Currency { Id = Guid.Parse("8f4e3de1-300d-4170-af62-b03ff8028d56"), Name = "Czech koruna", Code3 = "CZK", Symbol = "Kč", Plural = "Czech korun" },
                new Currency { Id = Guid.Parse("86ba8684-3ed5-4afb-b8c3-e069d1def19f"), Name = "Djibouti franc", Code3 = "DJF", Symbol = "₣", Plural = "Djibouti francs" },
                new Currency { Id = Guid.Parse("3755dd5e-e409-4e2d-a989-16c42cb1c593"), Name = "Danish krone", Code3 = "DKK", Symbol = "kr", Plural = "Danish kroner" },
                new Currency { Id = Guid.Parse("e7e33739-6ae0-43ba-9b80-56f6f0eee721"), Name = "Dominican peso", Code3 = "DOP", Symbol = "RD$", Plural = "Dominican pesos" },
                new Currency { Id = Guid.Parse("cfaac572-0d03-45f9-8d00-bdb7ea4605dd"), Name = "Algerian dinar", Code3 = "DZD", Symbol = "د.ج", Plural = "Algerian dinars" },
                new Currency { Id = Guid.Parse("a3cd1e66-fe13-4a79-b269-f8a9391bc595"), Name = "Estonian kroon", Code3 = "EEK", Symbol = "kr", Plural = "Estonian krooni" },
                new Currency { Id = Guid.Parse("202bf744-2038-4658-bab4-794962bf7b2e"), Name = "Egyptian pound", Code3 = "EGP", Symbol = "E £", Plural = "Egyptian pounds" },
                new Currency { Id = Guid.Parse("5d88271e-05bb-46fa-b02a-d129d195e86a"), Name = "Nakfa", Code3 = "ERN", Symbol = "Nfk", Plural = "Nakfas" },
                new Currency { Id = Guid.Parse("502e3289-427f-4681-a52d-75e6020288ff"), Name = "Ethiopian birr", Code3 = "ETB", Symbol = "Br", Plural = "Ethiopian birrs" },
                new Currency { Id = Guid.Parse("81a1b960-d26a-4e45-9473-edf0bc2e0f96"), Name = "Euro", Code3 = "EUR", Symbol = "€", Plural = "Euros" },
                new Currency { Id = Guid.Parse("fc01207f-0299-4191-a21f-3d851d335ad4"), Name = "Fiji dollar", Code3 = "FJD", Symbol = "$", Plural = "Fiji dollars" },
                new Currency { Id = Guid.Parse("562a2ae9-fd93-4da8-9ef9-726ea8a992c9"), Name = "Falkland Islands (Malvinas) pound", Code3 = "FKP", Symbol = "£", Plural = "Falkland Islands (Malvinas) pounds" },
                new Currency { Id = Guid.Parse("00f96cc1-93db-4361-b53a-07e93f34c514"), Name = "Pound sterling", Code3 = "GBP", Symbol = "£", Plural = "Pounds sterling" },
                new Currency { Id = Guid.Parse("a28e6f8d-d6c3-4b59-94d5-f7073fb41ef9"), Name = "Lari", Code3 = "GEL", Symbol = "ლ", Plural = "Lari" },
                new Currency { Id = Guid.Parse("eee5778e-a203-4f0c-a0d8-85854b4e1aab"), Name = "Ghana cedi", Code3 = "GHS", Symbol = "GH¢", Plural = "Ghana cedis" },
                new Currency { Id = Guid.Parse("526cc251-7274-47b8-9918-50cf6cd93837"), Name = "Gibraltar pound", Code3 = "GIP", Symbol = "£", Plural = "Gibraltar pounds" },
                new Currency { Id = Guid.Parse("2ad7ceac-fb94-4e69-83f6-546ff53f6dbe"), Name = "Dalasi", Code3 = "GMD", Symbol = "D", Plural = "Dalasi" },
                new Currency { Id = Guid.Parse("577173ba-078b-4869-97cc-5290334b51f0"), Name = "Guinean franc", Code3 = "GNF", Symbol = "₣", Plural = "Guinean francs" },
                new Currency { Id = Guid.Parse("32c947ce-1fe7-4525-9f36-41ca33fcf19e"), Name = "Quetzal", Code3 = "GTQ", Symbol = "Q", Plural = "Quetzales" },
                new Currency { Id = Guid.Parse("ff8b54b4-4767-40ca-9bd9-385a5f42929e"), Name = "Guinea-Bissau peso", Code3 = "GWP", Symbol = "$", Plural = "Guinea-Bissau pesos" },
                new Currency { Id = Guid.Parse("c8667ec8-9671-4800-85b7-b16fd7917156"), Name = "Guyana dollar", Code3 = "GYD", Symbol = "$", Plural = "Guyana dollars" },
                new Currency { Id = Guid.Parse("5fbe7960-72b9-4afa-84db-f8cc1473bc9a"), Name = "Hong Kong dollar", Code3 = "HKD", Symbol = "$", Plural = "Hong Kong dollars" },
                new Currency { Id = Guid.Parse("ce40007a-fe85-4035-8e36-a867e104920e"), Name = "Lempira", Code3 = "HNL", Symbol = "L", Plural = "Lempiras" },
                new Currency { Id = Guid.Parse("bd295809-8418-4342-aa53-8b45a1bec5bb"), Name = "Kuna", Code3 = "HRK", Symbol = "kn", Plural = "Kunas" },
                new Currency { Id = Guid.Parse("b04aff33-cf3b-45de-8b59-f5cea73caa0a"), Name = "Haitian gourde", Code3 = "HTG", Symbol = "G", Plural = "Haitian gourdes" },
                new Currency { Id = Guid.Parse("63346b08-8e7d-4a39-b1e1-9d85e5121631"), Name = "Forint", Code3 = "HUF", Symbol = "Ft", Plural = "Forints" },
                new Currency { Id = Guid.Parse("8fd3f2af-3ed8-4b17-abbc-fc9d8aadea4e"), Name = "Rupiah", Code3 = "IDR", Symbol = "Rp", Plural = "Rupiahs" },
                new Currency { Id = Guid.Parse("1d98496b-3583-46f0-b42c-73726bc92360"), Name = "New Israeli sheqel", Code3 = "ILS", Symbol = "₪", Plural = "New Israeli sheqels" },
                new Currency { Id = Guid.Parse("fa568b86-8e82-456c-bd08-5bdcf9ae595b"), Name = "Indian rupee", Code3 = "INR", Symbol = "₹", Plural = "Indian rupees" },
                new Currency { Id = Guid.Parse("443d3178-c48b-48cc-9693-f02e31996b69"), Name = "Iraqi dinar", Code3 = "IQD", Symbol = "د.ع", Plural = "Iraqi dinars" },
                new Currency { Id = Guid.Parse("d849f6e4-05f2-466b-835f-a20d372f9568"), Name = "Iranian rial", Code3 = "IRR", Symbol = "﷼", Plural = "Iranian rials" },
                new Currency { Id = Guid.Parse("63f1636d-c5a8-43c3-bae9-1e0892a16d6d"), Name = "Icelandic króna", Code3 = "ISK", Symbol = "kr", Plural = "Icelandic krónur" },
                new Currency { Id = Guid.Parse("c080a6ef-a13f-4761-a0ec-2af59e6ca3f8"), Name = "Jamaican dollar", Code3 = "JMD", Symbol = "J$", Plural = "Jamaican dollars" },
                new Currency { Id = Guid.Parse("13719ead-c45e-468c-ad53-2a90de678029"), Name = "Jordanian dinar", Code3 = "JOD", Symbol = "د.ا", Plural = "Jordanian dinars" },
                new Currency { Id = Guid.Parse("84c642db-8857-49b5-bdfc-a2d655f96428"), Name = "Yen", Code3 = "JPY", Symbol = "¥", Plural = "Yen" },
                new Currency { Id = Guid.Parse("630a79bf-7cd4-4f3a-af10-ad182b5bf205"), Name = "Kenyan shilling", Code3 = "KES", Symbol = "SH", Plural = "Kenyan shillings" },
                new Currency { Id = Guid.Parse("000db371-07c3-4f01-92cd-de94ed140e7d"), Name = "Kyrgyz Som", Code3 = "KGS", Symbol = "лв", Plural = "Kyrgyz Soms" },
                new Currency { Id = Guid.Parse("181209f3-34bb-4fc6-82df-710c6ae5625b"), Name = "Riel", Code3 = "KHR", Symbol = "៛", Plural = "Riels" },
                new Currency { Id = Guid.Parse("07c95d0c-98d0-4be7-808c-b3b529730028"), Name = "Comoro franc", Code3 = "KMF", Symbol = "₣", Plural = "Comoro francs" },
                new Currency { Id = Guid.Parse("531a6f53-43f4-4576-9c52-97f6ac74b0e6"), Name = "Won", Code3 = "KRW", Symbol = "₩", Plural = "Won" },
                new Currency { Id = Guid.Parse("d501ca46-aba2-49ed-9af8-d96fe594456a"), Name = "Kuwaiti dinar", Code3 = "KWD", Symbol = "د.ك", Plural = "Kuwaiti dinars" },
                new Currency { Id = Guid.Parse("08b339d4-b5d4-4b80-964b-d63dc61e81b1"), Name = "Cayman Islands dollar", Code3 = "KYD", Symbol = "$", Plural = "Cayman Islands dollars" },
                new Currency { Id = Guid.Parse("22e51645-f524-4164-a7bb-2ca25e3f7b66"), Name = "Tenge", Code3 = "KZT", Symbol = "лв", Plural = "Tenge" },
                new Currency { Id = Guid.Parse("5cf6a865-98dc-4f95-9b1f-e6c4f78f62ee"), Name = "Kip", Code3 = "LAK", Symbol = "₭", Plural = "Kips" },
                new Currency { Id = Guid.Parse("0aa7a62a-11b8-47fe-8f02-e90443f5f8ad"), Name = "Lebanese pound", Code3 = "LBP", Symbol = "LBP", Plural = "Lebanese pounds" },
                new Currency { Id = Guid.Parse("1b93cb56-9061-4a56-b016-af14ac6ee0fd"), Name = "Sri Lankan rupee", Code3 = "LKR", Symbol = "₨", Plural = "Sri Lankan rupees" },
                new Currency { Id = Guid.Parse("7943d411-fb9b-4268-aef6-e36d598b14bf"), Name = "Liberian dollar", Code3 = "LRD", Symbol = "$", Plural = "Liberian dollars" },
                new Currency { Id = Guid.Parse("0aa7adc6-0016-44ab-9ceb-a3df9d94c6bc"), Name = "Loti", Code3 = "LSL", Symbol = "M", Plural = "Maloti" },
                new Currency { Id = Guid.Parse("0e4fd2a1-fca2-40c9-bd73-6479a13fb512"), Name = "Lithuanian litus", Code3 = "LTL", Symbol = "Lt", Plural = "Lithuanian litai" },
                new Currency { Id = Guid.Parse("9b34e0e1-757c-4e69-b1a2-1f93e25ebe88"), Name = "Latvian lats", Code3 = "LVL", Symbol = "Ls", Plural = "Latvian lats" },
                new Currency { Id = Guid.Parse("056da660-c2cb-4ac7-9da6-995810ff8e09"), Name = "Libyan dinar", Code3 = "LYD", Symbol = "ل.د", Plural = "Libyan dinar" },
                new Currency { Id = Guid.Parse("f8be9a73-bee0-47e8-952b-d264a8b720b0"), Name = "Moroccan dirham", Code3 = "MAD", Symbol = "د.م", Plural = "Moroccan dirhams" },
                new Currency { Id = Guid.Parse("5fa0d5cc-983c-436d-aada-f3848c7bad5a"), Name = "Moldovan leu", Code3 = "MDL", Symbol = "L", Plural = "Moldovan lei" },
                new Currency { Id = Guid.Parse("9c0e7483-a8d6-4ced-837c-bd2f4bc68b4b"), Name = "Malagasy Ariary", Code3 = "MGA", Symbol = "Ar", Plural = "Malagasy Ariaries" },
                new Currency { Id = Guid.Parse("d1f581fc-99b1-4564-87b7-2ece82d8570d"), Name = "Denar", Code3 = "MKD", Symbol = "ден", Plural = "Denari" },
                new Currency { Id = Guid.Parse("10abba60-de27-4d91-b6b8-9e872485e00d"), Name = "Kyat", Code3 = "MMK", Symbol = "K", Plural = "Kyats" },
                new Currency { Id = Guid.Parse("81be630a-d757-4da5-b4df-81dcc66fa055"), Name = "Tugrik", Code3 = "MNT", Symbol = "₮", Plural = "Tugriks" },
                new Currency { Id = Guid.Parse("09347574-cf53-4142-8a3c-4b747d2df1ba"), Name = "Pataca", Code3 = "MOP", Symbol = "MOP$", Plural = "Patacas" },
                new Currency { Id = Guid.Parse("cf0418a0-9e22-44e2-85c5-bc0622c762c2"), Name = "Ouguiya", Code3 = "MRO", Symbol = "UM", Plural = "Ouguiyas" },
                new Currency { Id = Guid.Parse("500c2fc9-93ff-4971-a920-8ef6eb1e07d1"), Name = "Ouguiya", Code3 = "MRU", Symbol = "UM", Plural = "Ouguiyas" },
                new Currency { Id = Guid.Parse("398e5f1d-6b48-4779-9905-74eaaae15a76"), Name = "Mauritian rupee", Code3 = "MUR", Symbol = "₨", Plural = "Mauritian rupees" },
                new Currency { Id = Guid.Parse("66837a54-2802-4d0a-b290-e56e23d312de"), Name = "Rufiyaa", Code3 = "MVR", Symbol = "Rf", Plural = "Rufiyaas" },
                new Currency { Id = Guid.Parse("b0566eeb-067f-47a3-8a73-02f3153635ee"), Name = "Kwacha", Code3 = "MWK", Symbol = "MK", Plural = "Kwacha" },
                new Currency { Id = Guid.Parse("89141a33-a8ad-437d-a877-9944568b8172"), Name = "Mexican peso", Code3 = "MXN", Symbol = "$", Plural = "Mexican pesos" },
                new Currency { Id = Guid.Parse("ee7550f7-965f-4635-b51c-0f2ca03c0169"), Name = "Malaysian ringgit", Code3 = "MYR", Symbol = "RM", Plural = "Malaysian ringgit" },
                new Currency { Id = Guid.Parse("2720c97a-f434-4f6a-966c-379f24c85d79"), Name = "Metical", Code3 = "MZN", Symbol = "MT", Plural = "Meticais" },
                new Currency { Id = Guid.Parse("c3950228-3a3d-4edc-9cef-aff52440d2c0"), Name = "Namibian dollar", Code3 = "NAD", Symbol = "N$", Plural = "Namibian dollar" },
                new Currency { Id = Guid.Parse("0f393913-8795-4ded-be14-b76a721787f5"), Name = "Naira", Code3 = "NGN", Symbol = "₦", Plural = "Naira" },
                new Currency { Id = Guid.Parse("dede3fec-dfa0-4e23-aa01-3790ad5bdef7"), Name = "Cordoba Oro", Code3 = "NIO", Symbol = "C$", Plural = "Cordobas Oro" },
                new Currency { Id = Guid.Parse("e061cb16-3146-4a3a-948e-92973065ec63"), Name = "Norwegian krone", Code3 = "NOK", Symbol = "kr", Plural = "Norwegian kroner" },
                new Currency { Id = Guid.Parse("238ea326-d416-459d-aced-895503f3e3c8"), Name = "Nepalese rupee", Code3 = "NPR", Symbol = "₨", Plural = "Nepalese rupees" },
                new Currency { Id = Guid.Parse("6f450580-4010-43fb-b6f9-067c37db0252"), Name = "New Zealand dollar", Code3 = "NZD", Symbol = "$", Plural = "New Zealand dollars" },
                new Currency { Id = Guid.Parse("b5ee806c-c823-43c3-8c2e-0854637937b9"), Name = "Omani rial", Code3 = "OMR", Symbol = "﷼", Plural = "Omani rials" },
                new Currency { Id = Guid.Parse("9a3f388e-37d4-4627-8a30-3b181173c589"), Name = "Balboa", Code3 = "PAB", Symbol = "B/.", Plural = "Balboas" },
                new Currency { Id = Guid.Parse("ad804988-fcf6-4ba0-8419-e982f77d6b7e"), Name = "Nuevo Sol", Code3 = "PEN", Symbol = "S/.", Plural = "Nuevo Soles" },
                new Currency { Id = Guid.Parse("355f755c-c472-40c4-8d0b-8628dde6414a"), Name = "Kina", Code3 = "PGK", Symbol = "K", Plural = "Kinas" },
                new Currency { Id = Guid.Parse("023197f3-b75d-4028-b65f-d5ce4666ef88"), Name = "Philippine peso", Code3 = "PHP", Symbol = "Php", Plural = "Philippine pesos" },
                new Currency { Id = Guid.Parse("fd642a42-76bd-4566-bd44-ee1c4bfeaee1"), Name = "Pakistani rupee", Code3 = "PKR", Symbol = "₨", Plural = "Pakistani rupees" },
                new Currency { Id = Guid.Parse("b8108219-6534-43c2-9afa-868b77ee6b9d"), Name = "Zloty", Code3 = "PLN", Symbol = "zł", Plural = "Zloty" },
                new Currency { Id = Guid.Parse("dc23fbf1-28cc-40d8-8dfc-f0c3e6049201"), Name = "Guarani", Code3 = "PYG", Symbol = "Gs", Plural = "Guaranis" },
                new Currency { Id = Guid.Parse("fe96676a-58bd-4309-8f45-94a4f5362380"), Name = "Qatari riyal", Code3 = "QAR", Symbol = "﷼", Plural = "Qatari riyals" },
                new Currency { Id = Guid.Parse("bb6f58af-6871-4f3b-8e68-16c615b9a7ae"), Name = "New Leu", Code3 = "RON", Symbol = "lei", Plural = "New Lei" },
                new Currency { Id = Guid.Parse("06d20c1b-0cd6-4426-b7a4-a76a27010ef5"), Name = "Serbian dinar", Code3 = "RSD", Symbol = "Дин.", Plural = "Serbian dinars" },
                new Currency { Id = Guid.Parse("611ffb55-aae8-4cca-923a-7a3c246c14fc"), Name = "Russian rouble", Code3 = "RUB", Symbol = "руб", Plural = "Russian roubles" },
                new Currency { Id = Guid.Parse("d4487ded-0120-4f47-a4eb-c522b2c1c45b"), Name = "Rwanda franc", Code3 = "RWF", Symbol = "R₣", Plural = "Rwanda francs" },
                new Currency { Id = Guid.Parse("afe4045d-3d67-4365-94f3-f61e792b25e3"), Name = "Saudi riyal", Code3 = "SAR", Symbol = "﷼", Plural = "Saudi riyals" },
                new Currency { Id = Guid.Parse("2f4dd201-09c7-493d-a188-82c98bde65a7"), Name = "Solomon Islands dollar", Code3 = "SBD", Symbol = "SI$", Plural = "Solomon Islands dollars" },
                new Currency { Id = Guid.Parse("0def5ec1-7183-46ec-939a-99ca805013f0"), Name = "Seychelles rupee", Code3 = "SCR", Symbol = "₨", Plural = "Seychelles rupees" },
                new Currency { Id = Guid.Parse("25c1177b-9e97-45bc-b492-d3e6c764128f"), Name = "Sudanese pound", Code3 = "SDG", Symbol = "£", Plural = "Sudanese pounds" },
                new Currency { Id = Guid.Parse("a9edd292-de95-4e75-85f8-62556105dc21"), Name = "Swedish krona", Code3 = "SEK", Symbol = "kr", Plural = "Swedish kronur" },
                new Currency { Id = Guid.Parse("c3522cff-7479-4cd1-b8da-1e5021589838"), Name = "Singapore dollar", Code3 = "SGD", Symbol = "$", Plural = "Singapore dollars" },
                new Currency { Id = Guid.Parse("c56f4eb5-daaa-4f4d-a3c1-96199a174048"), Name = "Saint Helena pound", Code3 = "SHP", Symbol = "£", Plural = "Saint Helena pounds" },
                new Currency { Id = Guid.Parse("41f3e2d8-b465-40ab-8e04-4c3f7a1f4de7"), Name = "Leone", Code3 = "SLL", Symbol = "Le", Plural = "Leones" },
                new Currency { Id = Guid.Parse("c4348c2a-36ba-4dc2-b45d-5085209caf6d"), Name = "Somali shilling", Code3 = "SOS", Symbol = "S", Plural = "Somali shillings" },
                new Currency { Id = Guid.Parse("aa76b5ba-49f5-4ad5-b9b1-c2fb2adff912"), Name = "Surinam dollar", Code3 = "SRD", Symbol = "$", Plural = "Surinam dollars" },
                new Currency { Id = Guid.Parse("cc8d3722-3e99-4a0f-a2b4-d0c44485f992"), Name = "South Sudanese pound", Code3 = "SSP", Symbol = "£", Plural = "South Sudanese pounds" },
                new Currency { Id = Guid.Parse("5b80c226-19bd-4054-ab71-a3abe666189b"), Name = "Dobra", Code3 = "STD", Symbol = "Db", Plural = "Dobras" },
                new Currency { Id = Guid.Parse("14a73aeb-c52b-4e65-98d2-e1fdb3f156a2"), Name = "El Salvador colon", Code3 = "SVC", Symbol = "$", Plural = "El Salvador colones" },
                new Currency { Id = Guid.Parse("1eb7326d-d93c-4d6d-933e-829616e6ffda"), Name = "Syrian pound", Code3 = "SYP", Symbol = "£S", Plural = "Syrian pounds" },
                new Currency { Id = Guid.Parse("b94c744c-6939-4fae-bfbc-73be73a0f7a1"), Name = "Lilangeni", Code3 = "SZL", Symbol = "E", Plural = "Emalangeni" },
                new Currency { Id = Guid.Parse("d0dd9e8b-1447-4e96-8650-480952ca088d"), Name = "Baht", Code3 = "THB", Symbol = "฿", Plural = "Baht" },
                new Currency { Id = Guid.Parse("2f5ece9d-c2c1-426a-aa85-6b9c9bc7c6e9"), Name = "Somoni", Code3 = "TJS", Symbol = "SM", Plural = "Somonis" },
                new Currency { Id = Guid.Parse("00cd2a2b-0056-4a0f-a67e-d8253d3f6059"), Name = "Manat", Code3 = "TMM", Symbol = "m", Plural = "Manat" },
                new Currency { Id = Guid.Parse("ea52cdc6-bee4-4d80-85a3-cd5e9fb068d5"), Name = "Tunisian dinar", Code3 = "TND", Symbol = "TND", Plural = "Tunisian dinars" },
                new Currency { Id = Guid.Parse("d8b1453b-9112-4b2a-a2bc-254cfca7864e"), Name = "Pa'anga", Code3 = "TOP", Symbol = "$", Plural = "Pa'anga" },
                new Currency { Id = Guid.Parse("34a05fff-fb2c-4f05-9c5d-66858efece57"), Name = "Turkish lira", Code3 = "TRY", Symbol = "TL", Plural = "Turkish liras" },
                new Currency { Id = Guid.Parse("6cca2984-1bda-4810-a81e-4f9e5e8885fc"), Name = "Trinidad and Tobago dollar", Code3 = "TTD", Symbol = "TT$", Plural = "Trinidad and Tobago dollars" },
                new Currency { Id = Guid.Parse("bd587ae1-5ad5-4b23-9dc4-fa73f2d3723f"), Name = "New Taiwan dollar", Code3 = "TWD", Symbol = "NT$", Plural = "New Taiwan dollars" },
                new Currency { Id = Guid.Parse("cebad91b-0bdf-415c-b7a1-ad38b44915fd"), Name = "Tanzanian shilling", Code3 = "TZS", Symbol = "Sh", Plural = "Tanzanian shillings" },
                new Currency { Id = Guid.Parse("5b543466-6028-4afb-a103-47888f1e6264"), Name = "Hryvnia", Code3 = "UAH", Symbol = "₴", Plural = "Hryvni" },
                new Currency { Id = Guid.Parse("5d67e99e-4885-4c18-bd5a-407bf84cfa75"), Name = "Ugandan shilling", Code3 = "UGX", Symbol = "UGX", Plural = "Ugandan shillings" },
                new Currency { Id = Guid.Parse("7ce57a4f-bf49-4c07-8b5a-801f1431fa22"), Name = "U.S. dollar", Code3 = "USD", Symbol = "$", Plural = "U.S. dollars" },
                new Currency { Id = Guid.Parse("e32a2be7-aa9c-44c0-8155-6d138ad4a950"), Name = "Uruguayo peso", Code3 = "UYU", Symbol = "$U", Plural = "Uruguayo pesos" },
                new Currency { Id = Guid.Parse("ccc3cfd3-507b-43de-a4cc-9a18e490a9de"), Name = "Uzbekistan sum", Code3 = "UZS", Symbol = "лв", Plural = "Uzbekistan sum" },
                new Currency { Id = Guid.Parse("7f223126-caf8-4bde-9e0d-6e688529e0c3"), Name = "Bolivar Fuerte", Code3 = "VEF", Symbol = "Bs", Plural = "Bolivares Fuerte" },
                new Currency { Id = Guid.Parse("8a959aec-852d-4f6e-863b-ad5db323e78c"), Name = "Dong", Code3 = "VND", Symbol = "₫", Plural = "Dongs" },
                new Currency { Id = Guid.Parse("4af1de3a-433a-43b0-a762-37172347207e"), Name = "Vatu", Code3 = "VUV", Symbol = "VT", Plural = "Vatu" },
                new Currency { Id = Guid.Parse("9a53163d-85e9-4f99-9ce3-01ecd20ee949"), Name = "Samoan Tala", Code3 = "WST", Symbol = "$", Plural = "Samoan Talas" },
                new Currency { Id = Guid.Parse("369a8041-6d84-4167-97cf-603aa3cf0aef"), Name = "CFA Franc - BEAC", Code3 = "XAF", Symbol = "Fr", Plural = "CFA Francs - BEAC" },
                new Currency { Id = Guid.Parse("87887e89-ec57-4448-bd5c-17c38f938bb8"), Name = "Eastern Caribbean dollar", Code3 = "XCD", Symbol = "$", Plural = "Eastern Caribbean dollars" },
                new Currency { Id = Guid.Parse("a933ef62-ee56-43af-ac6f-2b280e28c74a"), Name = "CFA franc - BCEAO", Code3 = "XOF", Symbol = "CFA", Plural = "CFA francs - BCEAO" },
                new Currency { Id = Guid.Parse("68584ee5-4962-426b-a3c0-6ec714989089"), Name = "Comptoirs Francais du Pacifique Francs", Code3 = "XPF", Symbol = "₣", Plural = "Comptoirs Francais du Pacifique Francs" },
                new Currency { Id = Guid.Parse("ac045fb8-e07a-4fcb-9283-cb2bdf00bb5e"), Name = "Yemeni rial", Code3 = "YER", Symbol = "﷼", Plural = "Yemeni rials" },
                new Currency { Id = Guid.Parse("97a5a296-96d0-469b-93a0-c9eb89a7bfe7"), Name = "Rand", Code3 = "ZAR", Symbol = "R", Plural = "Rand" },
                new Currency { Id = Guid.Parse("c964646b-e097-47ac-a637-26395905e79b"), Name = "Kwacha", Code3 = "ZMK", Symbol = "ZK", Plural = "Kwachas" },
                new Currency { Id = Guid.Parse("4e78ce83-dfdc-4b5d-b5c2-0307036508e8"), Name = "Kwacha", Code3 = "ZMW", Symbol = "ZK", Plural = "Kwachas" },
                new Currency { Id = Guid.Parse("40bae6d1-3f25-4056-97a8-793a32c51efa"), Name = "Zimbabwean dollar", Code3 = "ZWD", Symbol = "Z$", Plural = "Zimbabwean dollars" }

            };
        }
    }
}
