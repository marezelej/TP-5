namespace AccountManager.Domain
{
    /// <summary>
    /// Representa un documento de tipo Type y número Number
    /// </summary>
    public class Document
    {
        public string Number { set; get; }
        public DocumentType Type { set; get; }
    }
}