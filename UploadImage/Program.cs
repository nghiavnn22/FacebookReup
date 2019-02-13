using System;
using Fac
namespace UploadImage
{
    class Program
    {
        static void Main(string[] args)
        {
           Faceb
        }
        public void upVideoToFanpage(Fanpage fanpage, string filePath, string message, string time)
        {
            {
                var mediaObject = new FacebookMediaObject
                {
                    FileName = System.IO.Path.GetFileName(filePath),
                    ContentType = "image/mp4"
                };
                mediaObject.SetValue(System.IO.File.ReadAllBytes(filePath));
                try
                {
                    var fb = new FacebookClient(fanpage.accessToken);
                    Console.WriteLine(fanpage.accessToken);
                    Console.WriteLine(mediaObject.ToString());
                    var result = (IDictionary<string, object>)fb.Post(fanpage.id + "/videos", new Dictionary<string, object>
                                   {
                                         { "source", mediaObject },
                                        //{"published","false" },
                                        //{"scheduled_publish_time",time},
                                        { "description",message}

                                   });
                    var postId = (string)result["id"];

                    Console.WriteLine("Post Id: {0}", postId);
                    Console.WriteLine(fanpage.name + "da post xong" + filePath.ToString());

                    // Note: This json result is not the orginal json string as returned by Facebook.
                    Console.WriteLine("Json: {0}", result.ToString());
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

    }
}
