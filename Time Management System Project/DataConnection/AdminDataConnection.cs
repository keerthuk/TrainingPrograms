using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Time_Management_System_Project.DataConnection
{
    public class AdminDataConnection
    {
        string sqlConnectionStr = "Data Source=GOKUL-NOTEBOOK;Initial Catalog=Time Management System;Integrated Security=True";
        public string InsertTutorial(ProjectDetails projectDetailsObj)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("insert into Project values(" + projectDetailsObj.ProjectId + ",'" + projectDetailsObj.ProjectName + "','" + projectDetailsObj.StartDate + "','" + projectDetailsObj.EndDate + "','" + projectDetailsObj.is_active + "')", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Project Details Added Successfully";
        }
       /* public DataTable SelectTutorial()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select project.project_id, project.project_name, project.is_active,timesheet.time_id", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }*/
        public void EditTutorialById(int tutorialId)
        {

        }
    }
}