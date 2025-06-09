## Install instructions

### Prerequisites

- SUMO is installed and is on PATH

### Windows

- Navigate to the persistent storage: 

    `C:\Users\<YourUsername>\AppData\LocalLow\DefaultCompany\3D-Traffic-Geomapping`

- Copy the content of the `ExternalData` folder from the repository into the persistent storage

### MacOS 

Not supported (yet?)

## Libsumo build instructions

If libsumo is ever updated, SUMO has to be recompiled from scratch to integrate new features into the project.

### Dependencies

- CMake
- SWIG
- (This process works best on Unix-based systems)

### Process

- Download the SUMO binaries 

    ```bash
    git clone https://github.com/eclipse/sumo.git
    ```

- Configure the build 

    ```bash
    cd sumo
    mkdir build
    cd build
    cmake -DENABLE_CS_BINDINGS=ON ..
    ```

- Build

    ```bash
    make
    ```

- The generated .cs bindings can then be found in `build/src/libsumo/Eclipse.Sumo.Libsumo`
