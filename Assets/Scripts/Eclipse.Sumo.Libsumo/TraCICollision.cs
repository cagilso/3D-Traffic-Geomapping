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

public class TraCICollision : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal TraCICollision(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TraCICollision obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TraCICollision() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          libsumoPINVOKE.delete_TraCICollision(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string collider {
    set {
      libsumoPINVOKE.TraCICollision_collider_set(swigCPtr, value);
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = libsumoPINVOKE.TraCICollision_collider_get(swigCPtr);
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string victim {
    set {
      libsumoPINVOKE.TraCICollision_victim_set(swigCPtr, value);
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = libsumoPINVOKE.TraCICollision_victim_get(swigCPtr);
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string colliderType {
    set {
      libsumoPINVOKE.TraCICollision_colliderType_set(swigCPtr, value);
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = libsumoPINVOKE.TraCICollision_colliderType_get(swigCPtr);
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string victimType {
    set {
      libsumoPINVOKE.TraCICollision_victimType_set(swigCPtr, value);
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = libsumoPINVOKE.TraCICollision_victimType_get(swigCPtr);
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double colliderSpeed {
    set {
      libsumoPINVOKE.TraCICollision_colliderSpeed_set(swigCPtr, value);
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = libsumoPINVOKE.TraCICollision_colliderSpeed_get(swigCPtr);
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double victimSpeed {
    set {
      libsumoPINVOKE.TraCICollision_victimSpeed_set(swigCPtr, value);
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = libsumoPINVOKE.TraCICollision_victimSpeed_get(swigCPtr);
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string type {
    set {
      libsumoPINVOKE.TraCICollision_type_set(swigCPtr, value);
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = libsumoPINVOKE.TraCICollision_type_get(swigCPtr);
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string lane {
    set {
      libsumoPINVOKE.TraCICollision_lane_set(swigCPtr, value);
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = libsumoPINVOKE.TraCICollision_lane_get(swigCPtr);
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double pos {
    set {
      libsumoPINVOKE.TraCICollision_pos_set(swigCPtr, value);
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = libsumoPINVOKE.TraCICollision_pos_get(swigCPtr);
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string getString() {
    string ret = libsumoPINVOKE.TraCICollision_getString(swigCPtr);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TraCICollision() : this(libsumoPINVOKE.new_TraCICollision(), true) {
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
