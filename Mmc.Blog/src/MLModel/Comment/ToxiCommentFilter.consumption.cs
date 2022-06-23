﻿// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML;
using Microsoft.ML.Data;

namespace Mmc.Blog.MLModel.Comment
{
    public partial class ToxiCommentFilter
    {
        /// <summary>
        /// model input class for ToxiCommentFilter.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"comment_text")]
            public string Comment_text { get; set; }

            [ColumnName(@"target")]
            public float Target { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for ToxiCommentFilter.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName("PredictedLabel")]
            public float Prediction { get; set; }

            public float[] Score { get; set; }
        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("ToxiCommentFilter.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new(() => CreatePredictEngine(), true);
        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }
        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
