/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="measure-layout")]
public partial class MeasureLayout {
    
    private decimal measuredistanceField;
    
    private bool measuredistanceFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("measure-distance")]
    public decimal measuredistance {
        get {
            return this.measuredistanceField;
        }
        set {
            this.measuredistanceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measuredistanceSpecified {
        get {
            return this.measuredistanceFieldSpecified;
        }
        set {
            this.measuredistanceFieldSpecified = value;
        }
    }
}