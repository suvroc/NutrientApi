// -------------------------------------------------------------------------------------------------------------------- 
// <copyright file="IoC.cs" company="Web Advanced"> 
// Copyright 2012 Web Advanced (www.webadvanced.com) 
// Licensed under the Apache License, Version 2.0 (the "License"); 
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at 
// 
// http://www.apache.org/licenses/LICENSE-2.0 

// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS, 
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and 
// limitations under the License. 
// </copyright> 
// -------------------------------------------------------------------------------------------------------------------- 


using Nutrients.IoC.Registries;
using StructureMap;

namespace Nutrients.IoC.DependencyResolution
{
    public static class IoC
    {
        public static Container Container { get; set; }

        public static IContainer Initialize(params Registry[] registries)
        {
            Container = new Container(c =>
            {

                c.AddRegistry<CommonRegistry>();

                foreach (var registry in registries)
                {
                    c.AddRegistry(registry);
                }
            });

            return Container;
        }
    }


}