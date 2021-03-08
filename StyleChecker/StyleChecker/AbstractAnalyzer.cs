namespace StyleChecker
{
    using Microsoft.CodeAnalysis.Diagnostics;

    /// <summary>
    /// The abstraction of analyzers.
    /// </summary>
    public abstract class AbstractAnalyzer : DiagnosticAnalyzer
    {
        /// <inheritdoc/>
        public sealed override void Initialize(AnalysisContext context)
        {
            context.EnableConcurrentExecution();
            context.ConfigureGeneratedCodeAnalysis(
                GeneratedCodeAnalysisFlags.None);
            Register(context);
        }

        /// <summary>
        /// Resisters actions with the specified <see
        /// cref="AnalysisContext"/>.
        /// </summary>
        /// <param name="context">
        /// The analysis context.
        /// </param>
        private protected abstract void Register(AnalysisContext context);
    }
}
