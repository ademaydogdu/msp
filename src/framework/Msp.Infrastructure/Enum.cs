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
        BekleyenIrsaliye = 7
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
        Satis = 2,
        PaymentType = 3,
        CurrentGroupDefinitions = 4,
        InvoiceList = 5,
        Order = 6,
        CariList = 7,
        Depot = 8,
        BankEntry = 9,
        KasaHareketi = 10,
        MusteriList = 11,
        Company = 12,
        Users = 13
    }

    public enum DeleteForm
    {
        SatisDeleted = 1,
        UrunKarti = 2
    }

    public enum SpeedBarcode
    {
        EditBarcode = 1
    }


    public enum OrderFilter
    {
        Siparis = 1,
        SevkRapor = 2
    }

    public enum SaleBarcodeType
    {
        YeniKayit = 1,
        SilmeListeTemizleme = 2,
        Satis = 3,
        NakitSatis = 4,
        KrediKartiSatis = 5
    }



}
