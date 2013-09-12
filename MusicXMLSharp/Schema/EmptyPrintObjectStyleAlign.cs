/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="empty-print-object-style-align")]
public partial class EmptyPrintObjectStyleAlign {
    
    private YesNo printobjectField;
    
    private bool printobjectFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("print-object")]
    public YesNo printobject {
        get {
            return this.printobjectField;
        }
        set {
            this.printobjectField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool printobjectSpecified {
        get {
            return this.printobjectFieldSpecified;
        }
        set {
            this.printobjectFieldSpecified = value;
        }
    }
}