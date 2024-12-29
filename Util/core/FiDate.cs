using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrakYazilimLib.Util.core
{
	public class FiDate
	{
		public static string TxNowWoTime()
		{
			return DateOnly.FromDateTime(DateTime.Now).ToString("yyyy-MM-dd");
		}

		public static string TxNowWithTime()
		{
			return DateOnly.FromDateTime(DateTime.Now).ToString("yyyy-MM-dd");
		}

		public static string TxTimeStampForFile()
		{
			// Şu anki tarih ve saati al
			DateTime now = DateTime.Now;

			// Timestamp formatını oluştur (yyyyMMdd_HHmmss)
			return now.ToString("yyyyMMdd_HHmmss");
		}

		




	}
}
