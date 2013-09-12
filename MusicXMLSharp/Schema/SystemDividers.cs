/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="system-dividers")]
public partial class SystemDividers {
    
    private EmptyPrintObjectStyleAlign leftdividerField;
    
    private EmptyPrintObjectStyleAlign rightdividerField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("left-divider")]
    public EmptyPrintObjectStyleAlign leftdivider {
        get {
            return this.leftdividerField;
        }
        set {
            this.leftdividerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("right-divider")]
    public EmptyPrintObjectStyleAlign rightdivider {
        get {
            return this.rightdividerField;
        }
        set {
            this.rightdividerField = value;
        }
    }
}