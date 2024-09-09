using Newtonsoft.Json;
namespace ThuongMaiDienTu.Areas.Admin.Extensions
{
  public static class SessionExtension
  {
    public static T GetObject<T>(this ISession session, string key)
    {
      var value = session.GetString(key);
      if (value == null)
      {
        return default(T);
      }
      return JsonConvert.DeserializeObject<T>(value);
    }
  }
}
