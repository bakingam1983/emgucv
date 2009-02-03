using System;
using System.Collections.Generic;
using System.Text;
using Emgu.CV.Structure;

namespace Emgu.CV
{
   /// <summary>
   /// Parameters of blobtracker auto ver1
   /// </summary>
   public class BlobTrackerAutoParam
   {
      /// <summary>
      /// Number of frames needed for FG (foreground) detector to train.
      /// </summary>
      private int _FGTrainFrames;

      /// <summary>
      /// FGDetector module. If this field is NULL the Process FG mask is used.
      /// </summary>
      private ForgroundDetector _forgroundDetector;

      /// <summary>
      /// Selected blob detector module. If this field is NULL default blobdetector module will be created.
      /// </summary>
      private BlobDetector _blobDetector;

      /// <summary>
      /// Selected blob tracking module. If this field is NULL default blobtracker module will be created.
      /// </summary>
      private BlobTracker _blobTracker;

      /// <summary>
      /// Selected blob trajectory generator. If this field is NULL no generator is used.
      /// </summary>
      public IntPtr BTGen;

      /// <summary>
      /// Selected blob trajectory postprocessing module. If this field is NULL no postprocessing is done. 
      /// </summary>
      public IntPtr BTPP;

      /// <summary>
      /// 
      /// </summary>
      private int _usePPData;

      /// <summary>
      /// Selected blob trajectory analysis module. If this field is NULL no track analysis is done.   
      /// </summary>
      public IntPtr BTA;

      /// <summary>
      /// Selected blob detector module. If this field is NULL default blobdetector module will be created.
      /// </summary>
      public BlobDetector BlobDetector
      {
         get
         {
            return _blobDetector;
         }
         set
         {
            _blobDetector = value;
         }
      }
      /// <summary>
      /// Selected blob tracking module. If this field is NULL default blobtracker module will be created.
      /// </summary>
      public BlobTracker BlobTracker
      {
         get
         {
            return _blobTracker;
         }
         set
         {
            _blobTracker = value;
         }
      }

      /// <summary>
      /// Number of frames needed for FG (foreground) detector to train.
      /// </summary>
      public int FGTrainFrames
      {
         get
         {
            return _FGTrainFrames;
         }
         set
         {
            _FGTrainFrames = value;
         }
      }
      
      /// <summary>
      /// FGDetector module. If this field is NULL the Process FG mask is used.
      /// </summary>
      public ForgroundDetector ForgroundDetector
      {
         get
         {
            return _forgroundDetector;
         }
         set
         {
            _forgroundDetector = value;
         }
      }

      /// <summary>
      /// 
      /// </summary>
      public int UsePPData
      {
         get
         {
            return _usePPData;
         }
         set
         {
            _usePPData = value;
         }
      }

      /// <summary>
      /// Get the equivalent MCvBlobTrackerAutoParam1
      /// </summary>
      public MCvBlobTrackerAutoParam1 MCvBlobTrackerAutoParam1
      {
         get
         {
            MCvBlobTrackerAutoParam1 param = new MCvBlobTrackerAutoParam1();
            param.BD = BlobDetector;
            param.BT = BlobTracker;
            param.BTA = BTA;
            param.BTGen = BTGen;
            param.BTPP = BTPP;
            param.FG = ForgroundDetector;
            param.FGTrainFrames = FGTrainFrames;
            param.usePPData = UsePPData;
            return param;
         }
      }
   }
}