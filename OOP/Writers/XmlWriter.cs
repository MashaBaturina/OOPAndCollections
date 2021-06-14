using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace OOP
{
    public class XmlWriter
    {
        private static readonly string allVehiсleUnitsFilePath = Environment.CurrentDirectory + "//vehileUnits.xml";
        private static readonly string filteredVehicleUnitsFilePath = Environment.CurrentDirectory + "//vehileUnitsInfoAboutUnitsMoreThanXLiters.xml";
        private static readonly string vehicleUnitsGroupedByTransmissionTypeFilePath = Environment.CurrentDirectory + "//AllInfoAboutVihicleUnitsGroupByTransmissionType.xml";
        private static readonly string enginesOfBusesAndTrucksFilePath = Environment.CurrentDirectory + "//InfoAboutEnginesOfBusesAndTrucks.xml";

        private static readonly string vehicleUnitAttribute = "vehicleUnit";
        private static readonly string engineAttribute = "engine";
        private static readonly string powerAttribute = "power";
        private static readonly string volumeAttribute = "volume";
        private static readonly string typeAttribute = "type";
        private static readonly string serialNumberAttribute = "serialNumber";
        private static readonly string transmissionAttribute = "transmission";
        private static readonly string transmissionTypeAttribute = "transmissionType";
        private static readonly string gearsQuantityAttribute = "gearsQuantity";
        private static readonly string manufacturerAttribute = "manufacturer";
        private static readonly string chassisAttribute = "chassis";
        private static readonly string wheelsQuantityAttribute = "wheelsQuantity";
        private static readonly string numberAttribute = "number";
        private static readonly string permissibleCapacityAttribute = "permissibleCapacity";

        private static readonly string vehicleUnitKeyAttribute = "type";

        public static void WriteAllVehicleUnitsToXml(List<VehicleUnit> vehicleUnits)
        {
            XmlDocument xDoc = CreateXmlFileIfNotExists(allVehiсleUnitsFilePath);

            XmlElement xRoot = xDoc.DocumentElement;
            xRoot.RemoveAll();
            xDoc.Save(allVehiсleUnitsFilePath);

            for (int i = 0; i < vehicleUnits.Count; i++)
            {
                XmlElement vehileUnitElem = xDoc.CreateElement(vehicleUnitAttribute);
                XmlElement engineElem = xDoc.CreateElement(engineAttribute);

                XmlAttribute powerAttr = xDoc.CreateAttribute(powerAttribute);
                XmlAttribute volumeAttr = xDoc.CreateAttribute(volumeAttribute);
                XmlAttribute typeAttr = xDoc.CreateAttribute(typeAttribute);
                XmlAttribute serialNumberAttr = xDoc.CreateAttribute(serialNumberAttribute);

                XmlElement transmissionElem = xDoc.CreateElement(transmissionAttribute);
                XmlAttribute transmissionTypeAttr = xDoc.CreateAttribute(transmissionTypeAttribute);
                XmlAttribute gearsQuantityAttr = xDoc.CreateAttribute(gearsQuantityAttribute);
                XmlAttribute manufacturerAttr = xDoc.CreateAttribute(manufacturerAttribute);

                XmlElement chassisElem = xDoc.CreateElement(chassisAttribute);
                XmlAttribute wheelsQuantityAttr = xDoc.CreateAttribute(wheelsQuantityAttribute);
                XmlAttribute numberAttr = xDoc.CreateAttribute(numberAttribute);
                XmlAttribute permissibleCapacityAttr = xDoc.CreateAttribute(permissibleCapacityAttribute);

                XmlText powerText = xDoc.CreateTextNode(vehicleUnits[i].Engine.Power.ToString());
                XmlText volumeText = xDoc.CreateTextNode(vehicleUnits[i].Engine.Volume.ToString());
                XmlText typeText = xDoc.CreateTextNode(vehicleUnits[i].Engine.Type.ToString());
                XmlText serialNumberText = xDoc.CreateTextNode(vehicleUnits[i].Engine.SerialNumber.ToString());

                XmlText transmissionTypeText = xDoc.CreateTextNode(vehicleUnits[i].Transmission.TransmissionType.ToString());
                XmlText gearsQuantityText = xDoc.CreateTextNode(vehicleUnits[i].Transmission.GearsQuantity.ToString());
                XmlText manufacturerText = xDoc.CreateTextNode(vehicleUnits[i].Transmission.Manufacturer.ToString());

                XmlText wheelsQuantityText = xDoc.CreateTextNode(vehicleUnits[i].Chassis.WheelsQuantity.ToString());
                XmlText numberText = xDoc.CreateTextNode(vehicleUnits[i].Chassis.Number.ToString());
                XmlText permissibleCapacityText = xDoc.CreateTextNode(vehicleUnits[i].Chassis.PermissibleCapacity.ToString());

                powerAttr.AppendChild(powerText);
                volumeAttr.AppendChild(volumeText);
                typeAttr.AppendChild(typeText);
                serialNumberAttr.AppendChild(serialNumberText);

                transmissionTypeAttr.AppendChild(transmissionTypeText);
                gearsQuantityAttr.AppendChild(gearsQuantityText);
                manufacturerAttr.AppendChild(manufacturerText);

                wheelsQuantityAttr.AppendChild(wheelsQuantityText);
                numberAttr.AppendChild(numberText);
                permissibleCapacityAttr.AppendChild(permissibleCapacityText);

                vehileUnitElem.AppendChild(engineElem);
                engineElem.Attributes.Append(powerAttr);
                engineElem.Attributes.Append(volumeAttr);
                engineElem.Attributes.Append(typeAttr);
                engineElem.Attributes.Append(serialNumberAttr);

                vehileUnitElem.AppendChild(transmissionElem);
                transmissionElem.Attributes.Append(transmissionTypeAttr);
                transmissionElem.Attributes.Append(gearsQuantityAttr);
                transmissionElem.Attributes.Append(manufacturerAttr);

                vehileUnitElem.AppendChild(chassisElem);
                chassisElem.Attributes.Append(wheelsQuantityAttr);
                chassisElem.Attributes.Append(numberAttr);
                chassisElem.Attributes.Append(permissibleCapacityAttr);

                xRoot.AppendChild(vehileUnitElem);

                xDoc.Save(allVehiсleUnitsFilePath);
            }
        }

        public static void WriteFilteredVehicleUnitsToXml(List<VehicleUnit> vehicleUnits, double engineVolumeFilter)
        {
            XmlDocument xDoc = CreateXmlFileIfNotExists(filteredVehicleUnitsFilePath);

            XmlElement xRoot = xDoc.DocumentElement;

            xRoot.RemoveAll();
            xDoc.Save(filteredVehicleUnitsFilePath);

            for (int i = 0; i < vehicleUnits.Count; i++)
            {
                if (vehicleUnits[i].Engine.Volume > engineVolumeFilter)
                {
                    XmlElement vehileUnitElem = xDoc.CreateElement(vehicleUnitAttribute);
                    XmlElement engineElem = xDoc.CreateElement(engineAttribute);

                    XmlAttribute powerAttr = xDoc.CreateAttribute(powerAttribute);
                    XmlAttribute volumeAttr = xDoc.CreateAttribute(volumeAttribute);
                    XmlAttribute typeAttr = xDoc.CreateAttribute(typeAttribute);
                    XmlAttribute serialNumberAttr = xDoc.CreateAttribute(serialNumberAttribute);

                    XmlElement transmissionElem = xDoc.CreateElement(transmissionAttribute);
                    XmlAttribute transmissionTypeAttr = xDoc.CreateAttribute(transmissionTypeAttribute);
                    XmlAttribute gearsQuantityAttr = xDoc.CreateAttribute(gearsQuantityAttribute);
                    XmlAttribute manufacturerAttr = xDoc.CreateAttribute(manufacturerAttribute);

                    XmlElement chassisElem = xDoc.CreateElement(chassisAttribute);
                    XmlAttribute wheelsQuantityAttr = xDoc.CreateAttribute(wheelsQuantityAttribute);
                    XmlAttribute numberAttr = xDoc.CreateAttribute(numberAttribute);
                    XmlAttribute permissibleCapacityAttr = xDoc.CreateAttribute(permissibleCapacityAttribute);

                    XmlText powerText = xDoc.CreateTextNode(vehicleUnits[i].Engine.Power.ToString());
                    XmlText volumeText = xDoc.CreateTextNode(vehicleUnits[i].Engine.Volume.ToString());
                    XmlText typeText = xDoc.CreateTextNode(vehicleUnits[i].Engine.Type.ToString());
                    XmlText serialNumberText = xDoc.CreateTextNode(vehicleUnits[i].Engine.SerialNumber.ToString());

                    XmlText transmissionTypeText = xDoc.CreateTextNode(vehicleUnits[i].Transmission.TransmissionType.ToString());
                    XmlText gearsQuantityText = xDoc.CreateTextNode(vehicleUnits[i].Transmission.GearsQuantity.ToString());
                    XmlText manufacturerText = xDoc.CreateTextNode(vehicleUnits[i].Transmission.Manufacturer.ToString());

                    XmlText wheelsQuantityText = xDoc.CreateTextNode(vehicleUnits[i].Chassis.WheelsQuantity.ToString());
                    XmlText numberText = xDoc.CreateTextNode(vehicleUnits[i].Chassis.Number.ToString());
                    XmlText permissibleCapacityText = xDoc.CreateTextNode(vehicleUnits[i].Chassis.PermissibleCapacity.ToString());

                    powerAttr.AppendChild(powerText);
                    volumeAttr.AppendChild(volumeText);
                    typeAttr.AppendChild(typeText);
                    serialNumberAttr.AppendChild(serialNumberText);

                    transmissionTypeAttr.AppendChild(transmissionTypeText);
                    gearsQuantityAttr.AppendChild(gearsQuantityText);
                    manufacturerAttr.AppendChild(manufacturerText);

                    wheelsQuantityAttr.AppendChild(wheelsQuantityText);
                    numberAttr.AppendChild(numberText);
                    permissibleCapacityAttr.AppendChild(permissibleCapacityText);

                    vehileUnitElem.AppendChild(engineElem);
                    engineElem.Attributes.Append(powerAttr);
                    engineElem.Attributes.Append(volumeAttr);
                    engineElem.Attributes.Append(typeAttr);
                    engineElem.Attributes.Append(serialNumberAttr);

                    vehileUnitElem.AppendChild(transmissionElem);
                    transmissionElem.Attributes.Append(transmissionTypeAttr);
                    transmissionElem.Attributes.Append(gearsQuantityAttr);
                    transmissionElem.Attributes.Append(manufacturerAttr);

                    vehileUnitElem.AppendChild(chassisElem);
                    chassisElem.Attributes.Append(wheelsQuantityAttr);
                    chassisElem.Attributes.Append(numberAttr);
                    chassisElem.Attributes.Append(permissibleCapacityAttr);

                    xRoot.AppendChild(vehileUnitElem);

                    xDoc.Save(filteredVehicleUnitsFilePath);
                }
            }
        }

        public static void WriteVehicleUnitsGroupedByTransmissionTypeToXml(Dictionary<string, List<VehicleUnit>> filteredVehicleUnits)
        {
            XmlDocument xDoc = CreateXmlFileIfNotExists(vehicleUnitsGroupedByTransmissionTypeFilePath);

            XmlElement xRoot = xDoc.DocumentElement;

            xRoot.RemoveAll();
            xDoc.Save(vehicleUnitsGroupedByTransmissionTypeFilePath);

            foreach (KeyValuePair<string, List<VehicleUnit>> vehicleUnit in filteredVehicleUnits)
            {
                XmlElement vehicleUnitKeyElem = xDoc.CreateElement(transmissionAttribute);
                XmlAttribute vehicleUnitKeyAttr = xDoc.CreateAttribute(vehicleUnitKeyAttribute);
                XmlText vehicleUnitKeyText = xDoc.CreateTextNode(vehicleUnit.Key);

                vehicleUnitKeyAttr.AppendChild(vehicleUnitKeyText);
                vehicleUnitKeyElem.Attributes.Append(vehicleUnitKeyAttr);

                foreach (var vehicleUnitItem in vehicleUnit.Value)
                {
                    XmlElement vehicleUnitElem = xDoc.CreateElement(vehicleUnitAttribute);
                    XmlElement engineElem = xDoc.CreateElement(engineAttribute);

                    XmlAttribute powerAttr = xDoc.CreateAttribute(powerAttribute);
                    XmlAttribute volumeAttr = xDoc.CreateAttribute(volumeAttribute);
                    XmlAttribute typeAttr = xDoc.CreateAttribute(typeAttribute);
                    XmlAttribute serialNumberAttr = xDoc.CreateAttribute(serialNumberAttribute);

                    XmlElement transmissionElem = xDoc.CreateElement(transmissionAttribute);
                    XmlAttribute transmissionTypeAttr = xDoc.CreateAttribute(transmissionTypeAttribute);
                    XmlAttribute gearsQuantityAttr = xDoc.CreateAttribute(gearsQuantityAttribute);
                    XmlAttribute manufacturerAttr = xDoc.CreateAttribute(manufacturerAttribute);

                    XmlElement chassisElem = xDoc.CreateElement(chassisAttribute);
                    XmlAttribute wheelsQuantityAttr = xDoc.CreateAttribute(wheelsQuantityAttribute);
                    XmlAttribute numberAttr = xDoc.CreateAttribute(numberAttribute);
                    XmlAttribute permissibleCapacityAttr = xDoc.CreateAttribute(permissibleCapacityAttribute);

                    XmlText powerText = xDoc.CreateTextNode(vehicleUnitItem.Engine.Power.ToString());
                    XmlText volumeText = xDoc.CreateTextNode(vehicleUnitItem.Engine.Volume.ToString());
                    XmlText typeText = xDoc.CreateTextNode(vehicleUnitItem.Engine.Type.ToString());
                    XmlText serialNumberText = xDoc.CreateTextNode(vehicleUnitItem.Engine.SerialNumber.ToString());

                    XmlText transmissionTypeText = xDoc.CreateTextNode(vehicleUnitItem.Transmission.TransmissionType.ToString());
                    XmlText gearsQuantityText = xDoc.CreateTextNode(vehicleUnitItem.Transmission.GearsQuantity.ToString());
                    XmlText manufacturerText = xDoc.CreateTextNode(vehicleUnitItem.Transmission.Manufacturer.ToString());

                    XmlText wheelsQuantityText = xDoc.CreateTextNode(vehicleUnitItem.Chassis.WheelsQuantity.ToString());
                    XmlText numberText = xDoc.CreateTextNode(vehicleUnitItem.Chassis.Number.ToString());
                    XmlText permissibleCapacityText = xDoc.CreateTextNode(vehicleUnitItem.Chassis.PermissibleCapacity.ToString());

                    powerAttr.AppendChild(powerText);
                    volumeAttr.AppendChild(volumeText);
                    typeAttr.AppendChild(typeText);
                    serialNumberAttr.AppendChild(serialNumberText);

                    transmissionTypeAttr.AppendChild(transmissionTypeText);
                    gearsQuantityAttr.AppendChild(gearsQuantityText);
                    manufacturerAttr.AppendChild(manufacturerText);

                    wheelsQuantityAttr.AppendChild(wheelsQuantityText);
                    numberAttr.AppendChild(numberText);
                    permissibleCapacityAttr.AppendChild(permissibleCapacityText);

                    vehicleUnitElem.AppendChild(engineElem);
                    engineElem.Attributes.Append(powerAttr);
                    engineElem.Attributes.Append(volumeAttr);
                    engineElem.Attributes.Append(typeAttr);
                    engineElem.Attributes.Append(serialNumberAttr);

                    vehicleUnitElem.AppendChild(transmissionElem);
                    transmissionElem.Attributes.Append(transmissionTypeAttr);
                    transmissionElem.Attributes.Append(gearsQuantityAttr);
                    transmissionElem.Attributes.Append(manufacturerAttr);

                    vehicleUnitElem.AppendChild(chassisElem);
                    chassisElem.Attributes.Append(wheelsQuantityAttr);
                    chassisElem.Attributes.Append(numberAttr);
                    chassisElem.Attributes.Append(permissibleCapacityAttr);

                    vehicleUnitKeyElem.AppendChild(vehicleUnitElem);

                    xRoot.AppendChild(vehicleUnitKeyElem);

                    xDoc.Save(vehicleUnitsGroupedByTransmissionTypeFilePath);
                }
            }
        }

        public static void WriteEnginesOfBusesAndTrucksToXml(List<VehicleUnit> vehicleUnits)
        {
            XmlDocument xDoc = CreateXmlFileIfNotExists(enginesOfBusesAndTrucksFilePath);

            XmlElement xRoot = xDoc.DocumentElement;

            xRoot.RemoveAll();
            xDoc.Save(enginesOfBusesAndTrucksFilePath);

            for (int i = 0; i < vehicleUnits.Count; i++)
            {
                if (vehicleUnits[i] is Bus || vehicleUnits[i] is Truck)
                {
                    XmlElement vehicleUnitElem = xDoc.CreateElement(vehicleUnitAttribute);
                    XmlElement engineElem = xDoc.CreateElement(engineAttribute);

                    XmlAttribute powerAttr = xDoc.CreateAttribute(powerAttribute);
                    XmlAttribute volumeAttr = xDoc.CreateAttribute(volumeAttribute);
                    XmlAttribute typeAttr = xDoc.CreateAttribute(typeAttribute);
                    XmlAttribute serialNumberAttr = xDoc.CreateAttribute(serialNumberAttribute);

                    XmlText powerText = xDoc.CreateTextNode(vehicleUnits[i].Engine.Power.ToString());
                    XmlText volumeText = xDoc.CreateTextNode(vehicleUnits[i].Engine.Volume.ToString());
                    XmlText typeText = xDoc.CreateTextNode(vehicleUnits[i].Engine.Type.ToString());
                    XmlText serialNumberText = xDoc.CreateTextNode(vehicleUnits[i].Engine.SerialNumber.ToString());

                    powerAttr.AppendChild(powerText);
                    volumeAttr.AppendChild(volumeText);
                    typeAttr.AppendChild(typeText);
                    serialNumberAttr.AppendChild(serialNumberText);

                    vehicleUnitElem.AppendChild(engineElem);
                    engineElem.Attributes.Append(powerAttr);
                    engineElem.Attributes.Append(volumeAttr);
                    engineElem.Attributes.Append(typeAttr);
                    engineElem.Attributes.Append(serialNumberAttr);

                    xRoot.AppendChild(vehicleUnitElem);

                    xDoc.Save(enginesOfBusesAndTrucksFilePath);
                }
            }
        }

        private static XmlDocument CreateXmlFileIfNotExists(string filePath)
        {
            XmlDocument xDoc = new();

            if (File.Exists(filePath))
            {
                xDoc.Load(filePath);
            }
            else
            {
                XmlDeclaration XmlDec = xDoc.CreateXmlDeclaration("1.0", "utf-8", null);
                XmlElement vehicleUnitsElem = xDoc.CreateElement("vehicleUnits");
                xDoc.AppendChild(XmlDec);
                xDoc.AppendChild(vehicleUnitsElem);
            }

            return xDoc;
        }
    }
}
