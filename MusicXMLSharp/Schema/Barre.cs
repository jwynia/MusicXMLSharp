/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Barre {
    
    private StartStop typeField;
    
    private string colorField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public StartStop type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    public string color {
        get {
            return this.colorField;
        }
        set {
            this.colorField = value;
        }
    }
}