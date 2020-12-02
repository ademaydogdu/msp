using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml;
using Msp.Models.Models;
using System.Globalization;
using Msp.Service.Repository;
using Msp.App.Tool;

namespace Msp.App.Islemler
{
    public partial class frmDovizKurlari : DevExpress.XtraEditors.XtraForm
    {
        Repository _repository;
        List<ExchangeRateDTO> __List_exchanceRate;
        MspTool MspTool = new MspTool();


        List<CurrencyTypeDTO> __dl_List_CurrencyTypeSelect;
        public frmDovizKurlari()
        {
            InitializeComponent();
            _repository = new Repository();
            __List_exchanceRate = new List<ExchangeRateDTO>();
        }

        private void frmDovizKurlari_Load(object sender, EventArgs e)
        {
            this.dateEdit1.DateTime = DateTime.Today;
            bs_ExranceRate.DataSource = __List_exchanceRate;
            satirKontrol();
            MspTool.Get_Layout(this);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbi_InternetAl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string lcUrlBas = "http://www.tcmb.gov.tr/kurlar/";
                bool adresBulundu = false;
                DateTime simdiTarih = this.dateEdit1.DateTime.AddDays(-1);
                string lcUrl;
                int tryCount = 1;
                do
                {
                    lcUrl = lcUrlBas
                        + simdiTarih.Year.ToString()
                        + simdiTarih.Month.ToString().PadLeft(2, '0');
                    lcUrl += "/"
                        + simdiTarih.Day.ToString().PadLeft(2, '0')
                        + simdiTarih.Month.ToString().PadLeft(2, '0')
                        + simdiTarih.Year.ToString()
                        + ".xml";

                    XmlTextReader rdr1 = new XmlTextReader(lcUrl);
                    XmlDocument myxml1 = new XmlDocument();
                    try
                    {

                        myxml1.Load(rdr1);
                        adresBulundu = true;
                    }
                    catch
                    {
                        simdiTarih = simdiTarih.AddDays(-1);
                        tryCount += 1;
                        if (tryCount == 7)
                        {
                            XtraMessageBox.Show("Doviz Kurları Alınamadı !!!");
                            this.Cursor = Cursors.Default;
                            return;
                        }
                    }
                    finally
                    { }
                } while (adresBulundu == false);

                List<TCMBCurrency> exchangeRate = new List<TCMBCurrency>();
                XmlTextReader rdr = new XmlTextReader(lcUrl);
                XmlDocument myxml = new XmlDocument();
                myxml.Load(rdr);

                XmlNode tarih = myxml.SelectSingleNode("/Tarih_Date/@Tarih");
                XmlNodeList mylist = myxml.SelectNodes("/Tarih_Date/Currency");
                XmlNodeList adi = myxml.SelectNodes("/Tarih_Date/Currency/Isim");
                XmlNodeList kod = myxml.SelectNodes("/Tarih_Date/Currency/@Kod");
                XmlNodeList doviz_alis = myxml.SelectNodes("/Tarih_Date/Currency/ForexBuying");
                XmlNodeList doviz_satis = myxml.SelectNodes("/Tarih_Date/Currency/ForexSelling");
                XmlNodeList efektif_alis = myxml.SelectNodes("/Tarih_Date/Currency/BanknoteBuying");
                XmlNodeList efektif_satis = myxml.SelectNodes("/Tarih_Date/Currency/BanknoteSelling");

                for (int j = 0; j < doviz_alis.Count; j++)
                {
                    TCMBCurrency exchange = new TCMBCurrency
                    {
                        CurrencyCode = adi.Item(j).InnerText.ToString(),
                        Code = kod.Item(j).InnerText.ToString(),
                        ForexBuying = doviz_alis.Item(j).InnerText.ToString(),
                        ForexSelling = doviz_satis.Item(j).InnerText.ToString(),
                        BanknoteBuying = efektif_alis.Item(j).InnerText.ToString(),
                        BanknoteSelling = efektif_satis.Item(j).InnerText.ToString()
                    };
                    exchangeRate.Add(exchange);
                }

                NumberFormatInfo numInfo = System.Globalization.NumberFormatInfo.CurrentInfo;
                string ds = numInfo.NumberDecimalSeparator;
                string gs = numInfo.NumberGroupSeparator;

                foreach (var oRow in __List_exchanceRate)
                {
                    string lsCurrencyCode = oRow.CurrencyCode.ToString().Trim();
                    foreach (var intRow in exchangeRate)
                    {
                        if (intRow.Code.ToString().Trim() == lsCurrencyCode)
                        {
                            decimal lnefektif_alis = 0;
                            decimal lnefektif_satis = 0;
                            try { lnefektif_alis = Convert.ToDecimal(intRow.BanknoteBuying.ToString().Replace(gs, ds)); }
                            catch { }
                            try { lnefektif_satis = Convert.ToDecimal(intRow.BanknoteSelling.ToString().Replace(gs, ds)); }
                            catch { }

                            if (lsCurrencyCode.ToString().Trim() == "JPY")
                            {
                                oRow.Buying = Convert.ToDecimal(intRow.ForexBuying.ToString().Replace(gs, ds)) / 100;
                                oRow.Selling = Convert.ToDecimal(intRow.ForexSelling.ToString().Replace(gs, ds)) / 100;
                                oRow.EffectiveBuying = lnefektif_alis / 100;
                                oRow.EffectiveSelling = lnefektif_satis / 100;
                            }
                            else
                            {
                                oRow.Buying = Convert.ToDecimal(intRow.ForexBuying.ToString().Replace(gs, ds));
                                oRow.Selling = Convert.ToDecimal(intRow.ForexSelling.ToString().Replace(gs, ds));
                                oRow.EffectiveBuying = lnefektif_alis;
                                oRow.EffectiveSelling = lnefektif_satis;
                            }
                            break;
                        }
                    }
                }
                gc_DovizKurlari.RefreshDataSource();
                this.Cursor = Cursors.Default;
            }
            catch
            {
                XtraMessageBox.Show("Doviz Kurları Alınamadı !!!");
            }

        }

        private void frmDovizKurlari_FormClosing(object sender, FormClosingEventArgs e)
        {
            MspTool.do_Save_Layout(this);

        }


        private void satirKontrol()
        {
            if (__List_exchanceRate.Count == 0)
            {
                foreach (var item in __dl_List_CurrencyTypeSelect)
                {
                    __List_exchanceRate.Add(new ExchangeRateDTO
                    {
                        CurrDate = this.dateEdit1.DateTime,
                        CurrencyCode = item.CurrencyCode,
                        Buying = item.CurrencyCode.ToUpper() == "TL" ? 1 : 0,
                        RecId = 0,
                        Selling = item.CurrencyCode.ToUpper() == "TL" ? 1 : 0,
                        EffectiveBuying = item.CurrencyCode.ToUpper() == "TL" ? 1 : 0,
                        EffectiveSelling = item.CurrencyCode.ToUpper() == "TL" ? 1 : 0,
                    });
                }
            }
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            satirKontrol();
        }
    }
}