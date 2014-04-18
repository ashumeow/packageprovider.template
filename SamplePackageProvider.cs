// 
//  Copyright (c) Microsoft Corporation. All rights reserved. 
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  http://www.apache.org/licenses/LICENSE-2.0
//  
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  

namespace OneGet.PackageProvider.Template {
    using Utility;
    using Callback = System.Func<string, System.Collections.Generic.IEnumerable<object>, object>;

    public class SamplePackageProvider {
        #region implement packageprovider-interface

        public void AddPackageSource(string name, string location, bool trusted, Callback c){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request = new Request(c)) {
                // use the request object to interact with the OneGet core:
                request.Debug("Information","Calling 'AddPackageSource'" );
            }

        }
        public bool FindPackage(string name, string requiredVersion, string minimumVersion, string maximumVersion, Callback c){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request = new Request(c)) {
                // use the request object to interact with the OneGet core:
                request.Debug("Information","Calling 'FindPackage'" );
            }

            return  default(bool);
        }
        public bool FindPackageByFile(string file, Callback c){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request = new Request(c)) {
                // use the request object to interact with the OneGet core:
                request.Debug("Information","Calling 'FindPackageByFile'" );
            }

            return  default(bool);
        }
        public bool FindPackageByUri(string u, Callback c){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request = new Request(c)) {
                // use the request object to interact with the OneGet core:
                request.Debug("Information","Calling 'FindPackageByUri'" );
            }

            return  default(bool);
        }
        public void GetInstallationOptionDefinitions(Callback c){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request = new Request(c)) {
                // use the request object to interact with the OneGet core:
                request.Debug("Information","Calling 'GetInstallationOptionDefinitions'" );
            }

        }
        public bool GetInstalledPackages(string name, Callback c){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request = new Request(c)) {
                // use the request object to interact with the OneGet core:
                request.Debug("Information","Calling 'GetInstalledPackages'" );
            }

            return  default(bool);
        }
        public void GetMetadataDefinitions(Callback c){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request = new Request(c)) {
                // use the request object to interact with the OneGet core:
                request.Debug("Information","Calling 'GetMetadataDefinitions'" );
            }

        }

        /// <summary>
            /// Returns the name of the Provider. Doesn't need callback .
            /// </summary>
            /// <returns></returns>
        public string GetPackageProviderName(){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.

            return  default(string);
        }
        public bool GetPackageSources(Callback c){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request = new Request(c)) {
                // use the request object to interact with the OneGet core:
                request.Debug("Information","Calling 'GetPackageSources'" );
            }

            return  default(bool);
        }
        public void Initialize(Callback c){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request = new Request(c)) {
                // use the request object to interact with the OneGet core:
                request.Debug("Information","Calling 'Initialize'" );
            }
        }
        public bool InstallPackageByFastpath(string fastPath, Callback c){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request = new Request(c)) {
                // use the request object to interact with the OneGet core:
                request.Debug("Information","Calling 'InstallPackageByFastpath'" );
            }

            return  default(bool);
        }
        public bool InstallPackageByFile(string filePath, Callback c){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request = new Request(c)) {
                // use the request object to interact with the OneGet core:
                request.Debug("Information","Calling 'InstallPackageByFile'" );
            }

            return  default(bool);
        }
        public bool InstallPackageByUri(string u, Callback c){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request = new Request(c)) {
                // use the request object to interact with the OneGet core:
                request.Debug("Information","Calling 'InstallPackageByUri'" );
            }

            return  default(bool);
        }
        public bool IsTrustedPackageSource(string packageSource, Callback c){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request = new Request(c)) {
                // use the request object to interact with the OneGet core:
                request.Debug("Information","Calling 'IsTrustedPackageSource'" );
            }

            return  default(bool);
        }
        public bool IsValidPackageSource(string packageSource, Callback c){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request = new Request(c)) {
                // use the request object to interact with the OneGet core:
                request.Debug("Information","Calling 'IsValidPackageSource'" );
            }

            return  default(bool);
        }
        public void RemovePackageSource(string name, Callback c){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request = new Request(c)) {
                // use the request object to interact with the OneGet core:
                request.Debug("Information","Calling 'RemovePackageSource'" );
            }

        }
        public bool UninstallPackage(string fastPath, Callback c){
             // TODO: Fill in implementation
             // Delete this method if you do not need to implement it
             // Please don't throw an not implemented exception, it's not optimal.
            using (var request = new Request(c)) {
                // use the request object to interact with the OneGet core:
                request.Debug("Information","Calling 'UninstallPackage'" );
            }

            return  default(bool);
        }

        #endregion

    }
}