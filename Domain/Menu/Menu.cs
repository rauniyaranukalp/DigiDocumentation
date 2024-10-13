namespace Domain.Menu
{
    public class Menu
    {
        public string? _id { get; set; }
        public string menuName { get; set; } = null!;
    }

    public class SubMenu
    {
        public string? _id { get; set; }
        public string? subMenuName { get; set; }
        public string? menuId { get; set; }
    }
    public class ContentType
    {
        public string? _id { get; set; }
        public string? contentName { get; set; }
    }
    public class TextContent
    {
        public string? _id { get; set; }
        public string? header { get; set; }
        public string? textContent { get; set; }
        public string? footer { get; set; }
    }
    public class CurlContent
    {
        public string? _id { get; set; }
        public string? header { get; set; }
        public string? curlDescription { get; set; }
        public string? curlUrl { get; set; }
    }
    public class Content
    {
        public string? _id { get; set; }
        public string? contentTypeId { get; set; }
        public string? menuId { get; set; }
        public string? subMenuId { get; set; }
    }
}
