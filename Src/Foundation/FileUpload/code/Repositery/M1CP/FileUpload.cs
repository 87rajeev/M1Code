using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using M1CP.Foundation.FileUpload.Service.M1CP;
using System.Web.Mvc;
using M1CP.Feature.Form.Models;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;

namespace M1CP.Foundation.FileUpload.Repositery.M1CP
{
    public class FileUpload : IFileUpload
    {
        public string UploadFile(FileDetails fileDetails)
        {
            string connstring = GetConnectionString();
            string guid = string.Empty;
            using (SqlConnection con = new SqlConnection(connstring))
            {
                SqlCommand cmd = new SqlCommand("InsertImageData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DocType", fileDetails.DocumentType);
                cmd.Parameters.AddWithValue("@UserId", fileDetails.UserId);
                cmd.Parameters.AddWithValue("@FileRefernce", ReadFIle(fileDetails.FileContent));
                cmd.Parameters.AddWithValue("@FileSize", fileDetails.FileContent.ContentLength);
                cmd.Parameters.AddWithValue("@DocumentExtension", GetFileExtension(fileDetails.FileContent.FileName));
                cmd.Parameters.AddWithValue("@FileName", fileDetails.FileContent.FileName);
                cmd.Parameters.AddWithValue("@serviceId", fileDetails.serviceId);
                cmd.Parameters.Add("@usertypeid", SqlDbType.UniqueIdentifier).Direction = ParameterDirection.Output;
                con.Open();
                cmd.ExecuteNonQuery();
                guid = cmd.Parameters["@usertypeid"].Value.ToString();
                con.Close();
            }
            return guid;
        }


        public DownloadFile DownloadFilefromId(string Guid)
        {
            DownloadFile fileattribute = new DownloadFile();
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetfilefromGUID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@GUID", Guid);
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        fileattribute.FileStream = sdr["FileRefernce"].ToString();
                        fileattribute.FIleExtension = sdr["DocumentExtension"].ToString();
                        fileattribute.FileName = sdr["FileName"].ToString();
                    }
                    con.Close();
                }
            }

            //File.WriteAllBytes
            return fileattribute;
        }
        public void DeleteFile(string GUID)
        {
            DownloadFile fileattribute = new DownloadFile();
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("sp_DeletefilefromGUID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@GUID", GUID);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

        }

        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        }

        public byte[] ReadFIle(HttpPostedFileBase fileStream)
        {
            byte[] bytes;
            using (BinaryReader br = new BinaryReader(fileStream.InputStream))
            {
                bytes = br.ReadBytes(fileStream.ContentLength);
            }
            return bytes;
        }

        public string GetFileExtension(string fileName)
        {
            return System.IO.Path.GetExtension(fileName);
        }
    }
}