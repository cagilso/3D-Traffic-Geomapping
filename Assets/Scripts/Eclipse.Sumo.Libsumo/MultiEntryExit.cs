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

public class MultiEntryExit : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MultiEntryExit(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MultiEntryExit obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(MultiEntryExit obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~MultiEntryExit() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsumoPINVOKE.delete_MultiEntryExit(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public static StringVector getEntryLanes(string detID) {
    StringVector ret = new StringVector(libsumoPINVOKE.MultiEntryExit_getEntryLanes(detID), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static StringVector getExitLanes(string detID) {
    StringVector ret = new StringVector(libsumoPINVOKE.MultiEntryExit_getExitLanes(detID), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static DoubleVector getEntryPositions(string detID) {
    DoubleVector ret = new DoubleVector(libsumoPINVOKE.MultiEntryExit_getEntryPositions(detID), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static DoubleVector getExitPositions(string detID) {
    DoubleVector ret = new DoubleVector(libsumoPINVOKE.MultiEntryExit_getExitPositions(detID), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int getLastStepVehicleNumber(string detID) {
    int ret = libsumoPINVOKE.MultiEntryExit_getLastStepVehicleNumber(detID);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double getLastStepMeanSpeed(string detID) {
    double ret = libsumoPINVOKE.MultiEntryExit_getLastStepMeanSpeed(detID);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static StringVector getLastStepVehicleIDs(string detID) {
    StringVector ret = new StringVector(libsumoPINVOKE.MultiEntryExit_getLastStepVehicleIDs(detID), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int getLastStepHaltingNumber(string detID) {
    int ret = libsumoPINVOKE.MultiEntryExit_getLastStepHaltingNumber(detID);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double getLastIntervalMeanTravelTime(string detID) {
    double ret = libsumoPINVOKE.MultiEntryExit_getLastIntervalMeanTravelTime(detID);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double getLastIntervalMeanHaltsPerVehicle(string detID) {
    double ret = libsumoPINVOKE.MultiEntryExit_getLastIntervalMeanHaltsPerVehicle(detID);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double getLastIntervalMeanTimeLoss(string detID) {
    double ret = libsumoPINVOKE.MultiEntryExit_getLastIntervalMeanTimeLoss(detID);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int getLastIntervalVehicleSum(string detID) {
    int ret = libsumoPINVOKE.MultiEntryExit_getLastIntervalVehicleSum(detID);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static StringVector getIDList() {
    StringVector ret = new StringVector(libsumoPINVOKE.MultiEntryExit_getIDList(), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int getIDCount() {
    int ret = libsumoPINVOKE.MultiEntryExit_getIDCount();
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string getParameter(string objectID, string key) {
    string ret = libsumoPINVOKE.MultiEntryExit_getParameter(objectID, key);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static StringStringPair getParameterWithKey(string objectID, string key) {
    StringStringPair ret = new StringStringPair(libsumoPINVOKE.MultiEntryExit_getParameterWithKey(objectID, key), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void setParameter(string objectID, string key, string value) {
    libsumoPINVOKE.MultiEntryExit_setParameter(objectID, key, value);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribe(string objectID, IntVector varIDs, double begin, double end, TraCIResults parameters) {
    libsumoPINVOKE.MultiEntryExit_subscribe__SWIG_0(objectID, IntVector.getCPtr(varIDs), begin, end, TraCIResults.getCPtr(parameters));
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribe(string objectID, IntVector varIDs, double begin, double end) {
    libsumoPINVOKE.MultiEntryExit_subscribe__SWIG_1(objectID, IntVector.getCPtr(varIDs), begin, end);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribe(string objectID, IntVector varIDs, double begin) {
    libsumoPINVOKE.MultiEntryExit_subscribe__SWIG_2(objectID, IntVector.getCPtr(varIDs), begin);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribe(string objectID, IntVector varIDs) {
    libsumoPINVOKE.MultiEntryExit_subscribe__SWIG_3(objectID, IntVector.getCPtr(varIDs));
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribe(string objectID) {
    libsumoPINVOKE.MultiEntryExit_subscribe__SWIG_4(objectID);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void unsubscribe(string objectID) {
    libsumoPINVOKE.MultiEntryExit_unsubscribe(objectID);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribeContext(string objectID, int domain, double dist, IntVector varIDs, double begin, double end, TraCIResults parameters) {
    libsumoPINVOKE.MultiEntryExit_subscribeContext__SWIG_0(objectID, domain, dist, IntVector.getCPtr(varIDs), begin, end, TraCIResults.getCPtr(parameters));
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribeContext(string objectID, int domain, double dist, IntVector varIDs, double begin, double end) {
    libsumoPINVOKE.MultiEntryExit_subscribeContext__SWIG_1(objectID, domain, dist, IntVector.getCPtr(varIDs), begin, end);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribeContext(string objectID, int domain, double dist, IntVector varIDs, double begin) {
    libsumoPINVOKE.MultiEntryExit_subscribeContext__SWIG_2(objectID, domain, dist, IntVector.getCPtr(varIDs), begin);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribeContext(string objectID, int domain, double dist, IntVector varIDs) {
    libsumoPINVOKE.MultiEntryExit_subscribeContext__SWIG_3(objectID, domain, dist, IntVector.getCPtr(varIDs));
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribeContext(string objectID, int domain, double dist) {
    libsumoPINVOKE.MultiEntryExit_subscribeContext__SWIG_4(objectID, domain, dist);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void unsubscribeContext(string objectID, int domain, double dist) {
    libsumoPINVOKE.MultiEntryExit_unsubscribeContext(objectID, domain, dist);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static SubscriptionResults getAllSubscriptionResults() {
    SubscriptionResults ret = new SubscriptionResults(libsumoPINVOKE.MultiEntryExit_getAllSubscriptionResults(), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static TraCIResults getSubscriptionResults(string objectID) {
    TraCIResults ret = new TraCIResults(libsumoPINVOKE.MultiEntryExit_getSubscriptionResults(objectID), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ContextSubscriptionResults getAllContextSubscriptionResults() {
    ContextSubscriptionResults ret = new ContextSubscriptionResults(libsumoPINVOKE.MultiEntryExit_getAllContextSubscriptionResults(), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static SubscriptionResults getContextSubscriptionResults(string objectID) {
    SubscriptionResults ret = new SubscriptionResults(libsumoPINVOKE.MultiEntryExit_getContextSubscriptionResults(objectID), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void subscribeParameterWithKey(string objectID, string key, double beginTime, double endTime) {
    libsumoPINVOKE.MultiEntryExit_subscribeParameterWithKey__SWIG_0(objectID, key, beginTime, endTime);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribeParameterWithKey(string objectID, string key, double beginTime) {
    libsumoPINVOKE.MultiEntryExit_subscribeParameterWithKey__SWIG_1(objectID, key, beginTime);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribeParameterWithKey(string objectID, string key) {
    libsumoPINVOKE.MultiEntryExit_subscribeParameterWithKey__SWIG_2(objectID, key);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static int DOMAIN_ID {
    get {
      int ret = libsumoPINVOKE.MultiEntryExit_DOMAIN_ID_get();
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static int domainID() {
    int ret = libsumoPINVOKE.MultiEntryExit_domainID();
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
