## Install instructions

### Prerequisites

- Python 3 is installed
- SUMO is installed and is on PATH

### Windows

- Navigate to the persistent storage: 

    `C:\Users\<YourUsername>\AppData\LocalLow\DefaultCompany\3D-Traffic-Geomapping`

#### Install Python Virtual Environment

- Create a virtuel environment: `python3 -m venv win_venv`
- Activate the virtual environment: `.\win_venv\Scripts\activate`
- Install traci: `pip install traci`
- Exit the virtual environment (`deactivate`)

#### Copy Files

- Move the content of the `ExternalData` folder into the persistent storage

### MacOS 

Not supported (yet?)