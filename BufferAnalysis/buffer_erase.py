#------------------------------------------------------------------
# Author: ZhangYuehao
# Email: yuehaozhang@njtech.edu.cn
# Zhihu: https://www.zhihu.com/people/bu-meng-cheng-kong-46/posts
# GitHub: https://github.com/ZhangAilan
#-------------------------------------------------------------------
# Date: 2024/07/04
# Function:
#   Overlay the buffer layer and the building footprint layer, 
#   and then extract the area outside the building footprint
#-------------------------------------------------------------------
import arcpy
import os

def erase_building_area(buffer_layer, building_layer):
    arcpy.env.overwriteOutput = True
   
    buffer_name = os.path.splitext(os.path.basename(buffer_layer))[0]
    building_name = os.path.splitext(os.path.basename(building_layer))[0]
   
    output_path = os.path.dirname(buffer_layer)
    erase_output = os.path.join(output_path, f"erase_output_{buffer_name}_{building_name}.shp")
   
    arcpy.Erase_analysis(buffer_layer, building_layer, erase_output)
   
    return erase_output

if __name__ == "__main__":
    import sys
    if len(sys.argv) != 3:
        print("Usage: erase_building_area <buffer_layer> <building_layer>")
        sys.exit(1)

    buffer_layer = sys.argv[1]
    building_layer = sys.argv[2]

    result = erase_building_area(buffer_layer, building_layer)
    print(result)

