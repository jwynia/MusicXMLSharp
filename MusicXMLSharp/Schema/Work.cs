/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Work {
    
    private string worknumberField;
    
    private string worktitleField;
    
    private Opus opusField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("work-number")]
    public string worknumber {
        get {
            return this.worknumberField;
        }
        set {
            this.worknumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("work-title")]
    public string worktitle {
        get {
            return this.worktitleField;
        }
        set {
            this.worktitleField = value;
        }
    }
    
    /// <remarks/>
    public Opus opus {
        get {
            return this.opusField;
        }
        set {
            this.opusField = value;
        }
    }
}