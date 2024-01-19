using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace chattingProgram
{
	public partial class chattingroom : System.Web.UI.Page
	{
		List<int> chatID = new List<int>();
		protected void Page_Load(object sender, EventArgs e)
		{
			listening_talking();
		}

		protected void btnpre_click(object sender, EventArgs e)
		{
			Response.Redirect("https://www.youtube.com");
		}

		protected void btnEnter_Click(object sender, EventArgs e)
		{
			string sendingTxt = txtInput.InnerText;

			addTalk(sendingTxt);
			/*Response.Write("<script>var t1 = document.getElementById('안지영'); t1.scrollTop = t1.scrollHeight;</script>");*/
		}

		protected void addTalk(string txt)
		{
			if (txt != string.Empty)
			{
				chat_space.InnerHtml += "<li class=\"message-me\">" + $"<p>{txt}</p></li>";
				txtInput.InnerText = "";
			}
		}

		protected void listening_talking()
		{
			SqlConnection conn = new SqlConnection("");
			conn.Open();

			string query = "select * from talking";
			SqlCommand comm = new SqlCommand(query,conn);
			comm.ExecuteNonQuery();

			SqlDataReader reader = comm.ExecuteReader();

			while (reader.Read())
			{
				//if (!chatID.Exists(s => chatID.Contains(s)))
					addTalk(reader["content"].ToString());
				/*else
					continue;*/
			}

			conn.Close();
		}
	}
}