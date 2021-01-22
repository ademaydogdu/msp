﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Infrastructure
{
    class Enum
    {
    }
    public enum FormOpenType
    {
        New = 0,
        Copy = 1,
        Edit = 2,
        View = 3,
    }

    public enum InvoiceType
    {
        AlımFaturası = 1,
        SatisFaturasi = 2,
        AllFatura = 3,
        AlisIrsaliye = 4,
        SatisIrsaliye = 5,
        AllIrsaliye = 6,
    }

    public enum OrderType
    {
        AlisSiparis = 1,
        SatisSiparis = 2,
        AllSiparis = 3,
        BekleyenSiparis = 4
    }

    public enum SecRightType
    {
        Insert,
        Update,
        Delete,
        Preview
    }

    public enum DocumentType
    {
        StockList = 1,
        Satis = 2
    }

    public enum DeleteForm
    {
        SatisDeleted = 1,
        UrunKarti = 2
    }




}
