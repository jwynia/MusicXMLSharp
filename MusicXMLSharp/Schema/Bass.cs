/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Bass {
    
    private BassStep _bassStepField;
    
    private BassAlter _bassAlterField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bass-step")]
    public BassStep BassStep {
        get {
            return this._bassStepField;
        }
        set {
            this._bassStepField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bass-alter")]
    public BassAlter BassAlter {
        get {
            return this._bassAlterField;
        }
        set {
            this._bassAlterField = value;
        }
    }
}