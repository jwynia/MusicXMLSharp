/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="system-margins")]
public partial class SystemMargins {
    
    private decimal leftmarginField;
    
    private decimal rightmarginField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("left-margin")]
    public decimal leftmargin {
        get {
            return this.leftmarginField;
        }
        set {
            this.leftmarginField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("right-margin")]
    public decimal rightmargin {
        get {
            return this.rightmarginField;
        }
        set {
            this.rightmarginField = value;
        }
    }
}