//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.3.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Eclipse.Sumo.Libsumo {

public class TraCINextTLSDataVectorWrapped : TraCIResult {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal TraCINextTLSDataVectorWrapped(global::System.IntPtr cPtr, bool cMemoryOwn) : base(libsumoPINVOKE.TraCINextTLSDataVectorWrapped_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TraCINextTLSDataVectorWrapped obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          libsumoPINVOKE.delete_TraCINextTLSDataVectorWrapped(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public override string getString() {
    string ret = libsumoPINVOKE.TraCINextTLSDataVectorWrapped_getString(swigCPtr);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TraCINextTLSVector value {
    set {
      libsumoPINVOKE.TraCINextTLSDataVectorWrapped_value_set(swigCPtr, TraCINextTLSVector.getCPtr(value));
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = libsumoPINVOKE.TraCINextTLSDataVectorWrapped_value_get(swigCPtr);
      TraCINextTLSVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new TraCINextTLSVector(cPtr, false);
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public TraCINextTLSDataVectorWrapped() : this(libsumoPINVOKE.new_TraCINextTLSDataVectorWrapped(), true) {
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
