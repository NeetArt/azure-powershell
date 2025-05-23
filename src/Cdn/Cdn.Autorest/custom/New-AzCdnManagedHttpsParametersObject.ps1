
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for CdnManagedHttpsParameters.
.Description
Create an in-memory object for CdnManagedHttpsParameters.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.CdnManagedHttpsParameters
.Link
https://learn.microsoft.com/powershell/module/Az.Cdn/new-azcdnmanagedhttpsparametersobject
#>
function New-AzCdnManagedHttpsParametersObject {
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.ModelCmdletAttribute()]
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.CdnManagedHttpsParameters')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(Mandatory, HelpMessage="Type of certificate used.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("Shared", "Dedicated")]
        [string]
        $CertificateSourceParameterCertificateType,
        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("CdnCertificateSourceParameters", "KeyVaultCertificateSourceParameters")]
        [string]
        $CertificateSourceParameterTypeName,
        [Parameter(HelpMessage="TLS protocol version that will be used for Https.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("None", "TLS10", "TLS12")]
        [string]
        $MinimumTlsVersion,
        [Parameter(Mandatory, HelpMessage="Defines the TLS extension protocol that is used for secure delivery.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("ServerNameIndication", "IPBased")]
        [string]
        $ProtocolType,
        [Parameter(Mandatory, HelpMessage="Defines the source of the SSL certificate.")]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("Cdn")]
        [string]
        $CertificateSource
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.CdnManagedHttpsParameters]::New()

        if ($PSBoundParameters.ContainsKey('CertificateSourceParameterCertificateType')) {
            $Object.CertificateSourceParameterCertificateType = $CertificateSourceParameterCertificateType
        }
        if ($PSBoundParameters.ContainsKey('CertificateSourceParameterTypeName')) {
            $Object.CertificateSourceParameterTypeName = $CertificateSourceParameterTypeName
        }
        if ($PSBoundParameters.ContainsKey('MinimumTlsVersion')) {
            $Object.MinimumTlsVersion = $MinimumTlsVersion
        }
        if ($PSBoundParameters.ContainsKey('ProtocolType')) {
            $Object.ProtocolType = $ProtocolType
        }
        if ($PSBoundParameters.ContainsKey('CertificateSource')) {
            $Object.CertificateSource = $CertificateSource
        }
        return $Object
    }
}

