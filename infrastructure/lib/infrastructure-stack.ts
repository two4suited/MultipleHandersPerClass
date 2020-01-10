import * as cdk from '@aws-cdk/core';
import lambda = require('@aws-cdk/aws-lambda');

export class InfrastructureStack extends cdk.Stack {
  constructor(scope: cdk.Construct, id: string, props?: cdk.StackProps) {
    super(scope, id, props);

    

    const upper = new lambda.Function(this,'upper',
    {
      runtime: lambda.Runtime.DOTNET_CORE_2_1,
      code: lambda.Code.fromAsset("../src/bin/Debug/netcoreapp2.1/publish"),
      handler: "src::src.Function::ToUpper",
      functionName: "ToUpper",
      timeout : cdk.Duration.seconds(60)
    });     
    
    const lower = new lambda.Function(this,'lower',
    {
      runtime: lambda.Runtime.DOTNET_CORE_2_1,
      code: lambda.Code.fromAsset("../src/bin/Debug/netcoreapp2.1/publish"),
      handler: "src::src.Function::ToLower",
      functionName: "ToLower",
      timeout : cdk.Duration.seconds(60)
    }); 

  }
}
