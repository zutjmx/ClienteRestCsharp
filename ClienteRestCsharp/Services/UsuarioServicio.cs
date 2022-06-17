using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteRestCsharp.Models;
using System.Net;
using System.IO;

namespace ClienteRestCsharp.Services
{
    class UsuarioServicio
    {
        public string GetUsuarios(string url, string ruta)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(ruta, Method.Get);
                var response = client.Execute(request);
                return response.Content;
            } catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string PutUsuario(string url, string ruta, Usuario usuario)
        {
            try
            {
                
                string webAddr = url + ruta;
                var httpWebRequest = WebRequest.CreateHttp(webAddr);
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Accept = "application/json";
                httpWebRequest.Method = "POST";
                

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {

                    StringBuilder stringBuilder = new StringBuilder("");

                    stringBuilder.Append("{\"nombre\":\"").Append(usuario.nombre).Append("\"");
                    stringBuilder.Append(",\"email\":\"").Append(usuario.email).Append("\"");
                    stringBuilder.Append(",\"password\":\"").Append(usuario.password).Append("\"");
                    stringBuilder.Append("}");

                    string json = stringBuilder.ToString();

                    streamWriter.Write(json);
                    streamWriter.Flush();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    Console.WriteLine(responseText);
                    return responseText;

                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        public string PutCurso(string url, string ruta, Curso curso)
        {
            try
            {

                string webAddr = url + ruta;
                var httpWebRequest = WebRequest.CreateHttp(webAddr);
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Accept = "application/json";
                httpWebRequest.Method = "POST";


                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {

                    StringBuilder stringBuilder = new StringBuilder("");

                    stringBuilder.Append("{\"nombre\":\"").Append(curso.nombre).Append("\"");
                    stringBuilder.Append("}");

                    string json = stringBuilder.ToString();

                    streamWriter.Write(json);
                    streamWriter.Flush();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    Console.WriteLine(responseText);
                    return responseText;

                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

    }
}
