/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="page-layout")]
public partial class PageLayout {
    
    private decimal pageheightField;
    
    private decimal pagewidthField;
    
    private PageMargins[] _pageMarginsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("page-height")]
    public decimal pageheight {
        get {
            return this.pageheightField;
        }
        set {
            this.pageheightField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("page-width")]
    public decimal pagewidth {
        get {
            return this.pagewidthField;
        }
        set {
            this.pagewidthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("page-margins")]
    public PageMargins[] PageMargins {
        get {
            return this._pageMarginsField;
        }
        set {
            this._pageMarginsField = value;
        }
    }
}