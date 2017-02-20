namespace LivingSpec.WebApi.Validation
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Web.Http.Controllers;
    using System.Web.Http.Filters;
    using Models;
    using RootContracts.BehaviorContracts.Validation;

    public class ValidateModelStateAttribute : ActionFilterAttribute
    {
        //we are forced to Lazyject here because these evaulate ahead of IOC.
        private readonly Lazy<IModelStateErrorParser> _modelStateErrorParser = new Lazy<IModelStateErrorParser>(() => IocConfig.SimpleInjectorContainer.GetInstance<IModelStateErrorParser>());

        public override async Task OnActionExecutingAsync(HttpActionContext actionContext, CancellationToken cancellationToken)
        {
            this.OnActionExecuting(actionContext: actionContext);
        }

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (!actionContext.ModelState.IsValid)
            {
                actionContext.Response = actionContext.Request.CreateResponse(
                    statusCode: HttpStatusCode.BadRequest,
                    value: new ApiResponse<object>()
                    {
                        ValidationResult =
                            this._modelStateErrorParser.Value.GetErrorsFromModelState(actionContext.ModelState),
                        Payload = null,
                        Exception = null
                    });
            }
            else if (ArgsHaveNullValue(actionArguments: actionContext.ActionArguments))
            {
                //http://stackoverflow.com/questions/17923622/modelstate-isvalid-even-when-it-should-not-be
                //http://www.strathweb.com/2012/10/clean-up-your-web-api-controllers-with-model-validation-and-null-check-filters/

                var validationResult = new ValidationResult();
                foreach (var arg in actionContext.ActionArguments)
                {
                    if (arg.Value == null)
                    {
                        validationResult.ValidationFailures.Add(new ValidationFailure()
                        {
                            PropertyName = arg.Key,
                            Message = $"{arg.Key} cannot be null."
                        });
                    }
                }

                actionContext.Response = actionContext.Request.CreateResponse(
                    statusCode: HttpStatusCode.BadRequest,
                    value: new ApiResponse<object>()
                    {
                        ValidationResult = validationResult,
                        Payload = null,
                        Exception = null
                    });
            }
        }

        private bool ArgsHaveNullValue(Dictionary<string, object> actionArguments)
        {
            return actionArguments.ContainsValue(null);
        }
    }
}