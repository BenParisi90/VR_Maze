// Copyright 2014 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;

using System.Collections;

[RequireComponent(typeof(Collider))]
public class Highlight : MonoBehaviour {

  public Material inactiveMaterial;
  public Material gazedAtMaterial;

    public int changingMaterialIndex = 0;

  void Start() {
    SetGazedAt(false);
  }

  public void SetGazedAt(bool gazedAt) {
        if (inactiveMaterial != null && gazedAtMaterial != null) {
            
            Material newMaterial = gazedAt ? gazedAtMaterial : inactiveMaterial;
            Material[] materialsArray = GetComponent<Renderer>().materials;
            materialsArray[changingMaterialIndex] = newMaterial;
            GetComponent<Renderer>().materials = materialsArray;
            return;
    }
  }
}
