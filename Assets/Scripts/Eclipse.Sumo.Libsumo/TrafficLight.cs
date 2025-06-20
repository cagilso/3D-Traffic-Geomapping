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

public class TrafficLight : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TrafficLight(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TrafficLight obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TrafficLight obj) {
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

  ~TrafficLight() {
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
          libsumoPINVOKE.delete_TrafficLight(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public static string getRedYellowGreenState(string tlsID) {
    string ret = libsumoPINVOKE.TrafficLight_getRedYellowGreenState(tlsID);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static TraCILogicVector getAllProgramLogics(string tlsID) {
    TraCILogicVector ret = new TraCILogicVector(libsumoPINVOKE.TrafficLight_getAllProgramLogics(tlsID), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static StringVector getControlledJunctions(string tlsID) {
    StringVector ret = new StringVector(libsumoPINVOKE.TrafficLight_getControlledJunctions(tlsID), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static StringVector getControlledLanes(string tlsID) {
    StringVector ret = new StringVector(libsumoPINVOKE.TrafficLight_getControlledLanes(tlsID), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static TraCILinkVectorVector getControlledLinks(string tlsID) {
    TraCILinkVectorVector ret = new TraCILinkVectorVector(libsumoPINVOKE.TrafficLight_getControlledLinks(tlsID), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string getProgram(string tlsID) {
    string ret = libsumoPINVOKE.TrafficLight_getProgram(tlsID);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int getPhase(string tlsID) {
    int ret = libsumoPINVOKE.TrafficLight_getPhase(tlsID);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string getPhaseName(string tlsID) {
    string ret = libsumoPINVOKE.TrafficLight_getPhaseName(tlsID);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double getPhaseDuration(string tlsID) {
    double ret = libsumoPINVOKE.TrafficLight_getPhaseDuration(tlsID);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double getNextSwitch(string tlsID) {
    double ret = libsumoPINVOKE.TrafficLight_getNextSwitch(tlsID);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double getSpentDuration(string tlsID) {
    double ret = libsumoPINVOKE.TrafficLight_getSpentDuration(tlsID);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int getServedPersonCount(string tlsID, int index) {
    int ret = libsumoPINVOKE.TrafficLight_getServedPersonCount(tlsID, index);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static StringVector getBlockingVehicles(string tlsID, int linkIndex) {
    StringVector ret = new StringVector(libsumoPINVOKE.TrafficLight_getBlockingVehicles(tlsID, linkIndex), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static StringVector getRivalVehicles(string tlsID, int linkIndex) {
    StringVector ret = new StringVector(libsumoPINVOKE.TrafficLight_getRivalVehicles(tlsID, linkIndex), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static StringVector getPriorityVehicles(string tlsID, int linkIndex) {
    StringVector ret = new StringVector(libsumoPINVOKE.TrafficLight_getPriorityVehicles(tlsID, linkIndex), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static TraCISignalConstraintVector getConstraints(string tlsID, string tripId) {
    TraCISignalConstraintVector ret = new TraCISignalConstraintVector(libsumoPINVOKE.TrafficLight_getConstraints__SWIG_0(tlsID, tripId), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static TraCISignalConstraintVector getConstraints(string tlsID) {
    TraCISignalConstraintVector ret = new TraCISignalConstraintVector(libsumoPINVOKE.TrafficLight_getConstraints__SWIG_1(tlsID), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static TraCISignalConstraintVector getConstraintsByFoe(string foeSignal, string foeId) {
    TraCISignalConstraintVector ret = new TraCISignalConstraintVector(libsumoPINVOKE.TrafficLight_getConstraintsByFoe__SWIG_0(foeSignal, foeId), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static TraCISignalConstraintVector getConstraintsByFoe(string foeSignal) {
    TraCISignalConstraintVector ret = new TraCISignalConstraintVector(libsumoPINVOKE.TrafficLight_getConstraintsByFoe__SWIG_1(foeSignal), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static StringVector getIDList() {
    StringVector ret = new StringVector(libsumoPINVOKE.TrafficLight_getIDList(), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int getIDCount() {
    int ret = libsumoPINVOKE.TrafficLight_getIDCount();
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string getParameter(string objectID, string key) {
    string ret = libsumoPINVOKE.TrafficLight_getParameter(objectID, key);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static StringStringPair getParameterWithKey(string objectID, string key) {
    StringStringPair ret = new StringStringPair(libsumoPINVOKE.TrafficLight_getParameterWithKey(objectID, key), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void setParameter(string objectID, string key, string value) {
    libsumoPINVOKE.TrafficLight_setParameter(objectID, key, value);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribe(string objectID, IntVector varIDs, double begin, double end, TraCIResults parameters) {
    libsumoPINVOKE.TrafficLight_subscribe__SWIG_0(objectID, IntVector.getCPtr(varIDs), begin, end, TraCIResults.getCPtr(parameters));
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribe(string objectID, IntVector varIDs, double begin, double end) {
    libsumoPINVOKE.TrafficLight_subscribe__SWIG_1(objectID, IntVector.getCPtr(varIDs), begin, end);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribe(string objectID, IntVector varIDs, double begin) {
    libsumoPINVOKE.TrafficLight_subscribe__SWIG_2(objectID, IntVector.getCPtr(varIDs), begin);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribe(string objectID, IntVector varIDs) {
    libsumoPINVOKE.TrafficLight_subscribe__SWIG_3(objectID, IntVector.getCPtr(varIDs));
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribe(string objectID) {
    libsumoPINVOKE.TrafficLight_subscribe__SWIG_4(objectID);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void unsubscribe(string objectID) {
    libsumoPINVOKE.TrafficLight_unsubscribe(objectID);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribeContext(string objectID, int domain, double dist, IntVector varIDs, double begin, double end, TraCIResults parameters) {
    libsumoPINVOKE.TrafficLight_subscribeContext__SWIG_0(objectID, domain, dist, IntVector.getCPtr(varIDs), begin, end, TraCIResults.getCPtr(parameters));
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribeContext(string objectID, int domain, double dist, IntVector varIDs, double begin, double end) {
    libsumoPINVOKE.TrafficLight_subscribeContext__SWIG_1(objectID, domain, dist, IntVector.getCPtr(varIDs), begin, end);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribeContext(string objectID, int domain, double dist, IntVector varIDs, double begin) {
    libsumoPINVOKE.TrafficLight_subscribeContext__SWIG_2(objectID, domain, dist, IntVector.getCPtr(varIDs), begin);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribeContext(string objectID, int domain, double dist, IntVector varIDs) {
    libsumoPINVOKE.TrafficLight_subscribeContext__SWIG_3(objectID, domain, dist, IntVector.getCPtr(varIDs));
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribeContext(string objectID, int domain, double dist) {
    libsumoPINVOKE.TrafficLight_subscribeContext__SWIG_4(objectID, domain, dist);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void unsubscribeContext(string objectID, int domain, double dist) {
    libsumoPINVOKE.TrafficLight_unsubscribeContext(objectID, domain, dist);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static SubscriptionResults getAllSubscriptionResults() {
    SubscriptionResults ret = new SubscriptionResults(libsumoPINVOKE.TrafficLight_getAllSubscriptionResults(), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static TraCIResults getSubscriptionResults(string objectID) {
    TraCIResults ret = new TraCIResults(libsumoPINVOKE.TrafficLight_getSubscriptionResults(objectID), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static ContextSubscriptionResults getAllContextSubscriptionResults() {
    ContextSubscriptionResults ret = new ContextSubscriptionResults(libsumoPINVOKE.TrafficLight_getAllContextSubscriptionResults(), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static SubscriptionResults getContextSubscriptionResults(string objectID) {
    SubscriptionResults ret = new SubscriptionResults(libsumoPINVOKE.TrafficLight_getContextSubscriptionResults(objectID), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void subscribeParameterWithKey(string objectID, string key, double beginTime, double endTime) {
    libsumoPINVOKE.TrafficLight_subscribeParameterWithKey__SWIG_0(objectID, key, beginTime, endTime);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribeParameterWithKey(string objectID, string key, double beginTime) {
    libsumoPINVOKE.TrafficLight_subscribeParameterWithKey__SWIG_1(objectID, key, beginTime);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void subscribeParameterWithKey(string objectID, string key) {
    libsumoPINVOKE.TrafficLight_subscribeParameterWithKey__SWIG_2(objectID, key);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static int DOMAIN_ID {
    get {
      int ret = libsumoPINVOKE.TrafficLight_DOMAIN_ID_get();
      if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static int domainID() {
    int ret = libsumoPINVOKE.TrafficLight_domainID();
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void setRedYellowGreenState(string tlsID, string state) {
    libsumoPINVOKE.TrafficLight_setRedYellowGreenState(tlsID, state);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void setPhase(string tlsID, int index) {
    libsumoPINVOKE.TrafficLight_setPhase(tlsID, index);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void setPhaseName(string tlsID, string name) {
    libsumoPINVOKE.TrafficLight_setPhaseName(tlsID, name);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void setProgram(string tlsID, string programID) {
    libsumoPINVOKE.TrafficLight_setProgram(tlsID, programID);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void setPhaseDuration(string tlsID, double phaseDuration) {
    libsumoPINVOKE.TrafficLight_setPhaseDuration(tlsID, phaseDuration);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void setProgramLogic(string tlsID, TraCILogic logic) {
    libsumoPINVOKE.TrafficLight_setProgramLogic(tlsID, TraCILogic.getCPtr(logic));
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void addConstraint(string tlsID, string tripId, string foeSignal, string foeId, int type, int limit) {
    libsumoPINVOKE.TrafficLight_addConstraint__SWIG_0(tlsID, tripId, foeSignal, foeId, type, limit);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void addConstraint(string tlsID, string tripId, string foeSignal, string foeId, int type) {
    libsumoPINVOKE.TrafficLight_addConstraint__SWIG_1(tlsID, tripId, foeSignal, foeId, type);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void addConstraint(string tlsID, string tripId, string foeSignal, string foeId) {
    libsumoPINVOKE.TrafficLight_addConstraint__SWIG_2(tlsID, tripId, foeSignal, foeId);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static TraCISignalConstraintVector swapConstraints(string tlsID, string tripId, string foeSignal, string foeId) {
    TraCISignalConstraintVector ret = new TraCISignalConstraintVector(libsumoPINVOKE.TrafficLight_swapConstraints(tlsID, tripId, foeSignal, foeId), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void removeConstraints(string tlsID, string tripId, string foeSignal, string foeId) {
    libsumoPINVOKE.TrafficLight_removeConstraints(tlsID, tripId, foeSignal, foeId);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void updateConstraints(string vehID, string tripId) {
    libsumoPINVOKE.TrafficLight_updateConstraints__SWIG_0(vehID, tripId);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void updateConstraints(string vehID) {
    libsumoPINVOKE.TrafficLight_updateConstraints__SWIG_1(vehID);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static TraCILogicVector getCompleteRedYellowGreenDefinition(string tlsID) {
    TraCILogicVector ret = new TraCILogicVector(libsumoPINVOKE.TrafficLight_getCompleteRedYellowGreenDefinition(tlsID), true);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void setCompleteRedYellowGreenDefinition(string tlsID, TraCILogic logic) {
    libsumoPINVOKE.TrafficLight_setCompleteRedYellowGreenDefinition(tlsID, TraCILogic.getCPtr(logic));
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void setNemaSplits(string tlsID, DoubleVector splits) {
    libsumoPINVOKE.TrafficLight_setNemaSplits(tlsID, DoubleVector.getCPtr(splits));
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void setNemaMaxGreens(string tlsID, DoubleVector maxGreens) {
    libsumoPINVOKE.TrafficLight_setNemaMaxGreens(tlsID, DoubleVector.getCPtr(maxGreens));
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void setNemaCycleLength(string tlsID, double cycleLength) {
    libsumoPINVOKE.TrafficLight_setNemaCycleLength(tlsID, cycleLength);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void setNemaOffset(string tlsID, double offset) {
    libsumoPINVOKE.TrafficLight_setNemaOffset(tlsID, offset);
    if (libsumoPINVOKE.SWIGPendingException.Pending) throw libsumoPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
