import traci
import traci.constants as tc
import xml.etree.ElementTree as ET 
import sys
import os

# Read command line arguments and define paths
persistent_path = sys.argv[1]
simulation_name = sys.argv[2]
passenger_trips_path = os.path.join(persistent_path, 'SumoOutput', simulation_name, 'osm.passenger.trips.xml')
osm_sumocfg_path = os.path.join(persistent_path, 'SumoOutput', simulation_name, 'osm.sumocfg')
output_path = os.path.join(persistent_path, 'SumoOutput', simulation_name, 'parser.output.xml')

# Parse passenger.trips.xml to retreive the number of vehicles
tree = ET.parse(passenger_trips_path) 
root = tree.getroot() 
number_of_vehicles = len(list(filter(lambda child : child.tag == 'trip', root)))

# Start the simulation
traci.start(['sumo', '-c', osm_sumocfg_path])
number_of_steps = 0

# Run the simulation while simultaneously writing output into .xml file
with open(output_path, 'w') as file:
    while traci.simulation.getMinExpectedNumber() > 0: # type: ignore
        file.write(f'  <step id=\"step{number_of_steps}\">\n')
        for veh_id in traci.vehicle.getIDList():
            veh_id_number = int(veh_id.split('veh')[1])
            x_pos = traci.vehicle.getPosition(veh_id)[0]
            y_pos = traci.vehicle.getPosition(veh_id)[1]
            file.write(f'    <position id=\"veh{veh_id_number}\" x_coordinate=\"{x_pos}\" y_coordinate=\"{y_pos}\"/>\n')
        file.write(f'  </step>\n')
        number_of_steps = number_of_steps + 1
        # Optional debugging output
        # print(number_of_steps)
        traci.simulationStep()
    traci.close()
    file.write(f'</root>\n')

# Repoen the file to prepend the number of steps and number of vehicles
with open(output_path, 'r+') as f:
    content = f.read()
    f.seek(0, 0)
    f.write((f'<root steps=\"{number_of_steps}\" vehicles=\"{number_of_vehicles}\">').rstrip('\r\n') + '\n' + content)

print('Finished!')