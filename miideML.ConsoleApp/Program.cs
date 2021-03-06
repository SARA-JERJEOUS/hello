// This file was auto-generated by ML.NET Model Builder. 

using System;
using MiideML.Model;
namespace MiideML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Abdominal_pain = 0F,
                Abnormal_menstruation = 0F,
                Acidity = 0F,
                Acute_liver_failure = 0F,
                Altered_sensorium = 0F,
                Anxiety = 0F,
                Back_pain = 0F,
                Belly_pain = 0F,
                Blackheads = 0F,
                Bladder_discomfort = 0F,
                Blister = 0F,
                Blood_in_sputum = 0F,
                Bloody_stool = 0F,
                Blurred_and_distorted_vision = 0F,
                Breathlessness = 0F,
                Brittle_nails = 0F,
                Bruising = 0F,
                Burning_micturition = 0F,
                Chest_pain = 0F,
                Chills = 0F,
                Cold_hands_and_feets = 0F,
                Coma = 0F,
                Congestion = 0F,
                Constipation = 0F,
                Continuous_feel_of_urine = 0F,
                Continuous_sneezing = 0F,
                Cough = 0F,
                Cramps = 0F,
                Dark_urine = 0F,
                Dehydration = 0F,
                Depression = 0F,
                Diarrhoea = 0F,
                Dischromic__patches = 1F,
                Distention_of_abdomen = 0F,
                Dizziness = 0F,
                Drying_and_tingling_lips = 0F,
                Enlarged_thyroid = 0F,
                Excessive_hunger = 0F,
                Extra_marital_contacts = 0F,
                Family_history = 0F,
                Fast_heart_rate = 0F,
                Fatigue = 0F,
                Fluid_overload = 0F,
                Foul_smell_of_urine = 0F,
                Headache = 0F,
                High_fever = 0F,
                Hip_joint_pain = 0F,
                History_of_alcohol_consumption = 0F,
                Increased_appetite = 0F,
                Indigestion = 0F,
                Inflammatory_nails = 0F,
                Internal_itching = 0F,
                Irregular_sugar_level = 0F,
                Irritability = 0F,
                Irritation_in_anus = 0F,
                Itching = 1F,
                Joint_pain = 0F,
                Knee_pain = 0F,
                Lack_of_concentration = 0F,
                Lethargy = 0F,
                Loss_of_appetite = 0F,
                Loss_of_balance = 0F,
                Loss_of_smell = 0F,
                Malaise = 0F,
                Mild_fever = 0F,
                Mood_swings = 0F,
                Movement_stiffness = 0F,
                Mucoid_sputum = 0F,
                Muscle_pain = 0F,
                Muscle_wasting = 0F,
                Muscle_weakness = 0F,
                Nausea = 0F,
                Neck_pain = 0F,
                Nodal_skin_eruptions = 1F,
                Obesity = 0F,
                Pain_behind_the_eyes = 0F,
                Pain_during_bowel_movements = 0F,
                Pain_in_anal_region = 0F,
                Painful_walking = 0F,
                Palpitations = 0F,
                Passage_of_gases = 0F,
                Patches_in_throat = 0F,
                Phlegm = 0F,
                Polyuria = 0F,
                Prominent_veins_on_calf = 0F,
                Puffy_face_and_eyes = 0F,
                Pus_filled_pimples = 0F,
                Receiving_blood_transfusion = 0F,
                Receiving_unsterile_injections = 0F,
                Red_sore_around_nose = 0F,
                Red_spots_over_body = 0F,
                Redness_of_eyes = 0F,
                Restlessness = 0F,
                Runny_nose = 0F,
                Rusty_sputum = 0F,
                Scurring = 0F,
                Shivering = 0F,
                Silver_like_dusting = 0F,
                Sinus_pressure = 0F,
                Skin_peeling = 0F,
                Skin_rash = 1F,
                Slurred_speech = 0F,
                Small_dents_in_nails = 0F,
                Spinning_movements = 0F,
                Spotting__urination = 0F,
                Stiff_neck = 0F,
                Stomach_bleeding = 0F,
                Stomach_pain = 0F,
                Sunken_eyes = 0F,
                Sweating = 0F,
                Swelled_lymph_nodes = 0F,
                Swelling_joints = 0F,
                Swelling_of_stomach = 0F,
                Swollen_blood_vessels = 0F,
                Swollen_extremeties = 0F,
                Swollen_legs = 0F,
                Throat_irritation = 0F,
                Toxic_look__typhos_ = 0F,
                Ulcers_on_tongue = 0F,
                Unsteadiness = 0F,
                Visual_disturbances = 0F,
                Vomiting = 0F,
                Watering_from_eyes = 0F,
                Weakness_in_limbs = 0F,
                Weakness_of_one_body_side = 0F,
                Weight_gain = 0F,
                Weight_loss = 0F,
                Yellow_crust_ooze = 0F,
                Yellow_urine = 0F,
                Yellowing_of_eyes = 0F,
                Yellowish_skin = 0F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Disease with predicted Disease from sample data...\n\n");
            Console.WriteLine($"Abdominal_pain: {sampleData.Abdominal_pain}");
            Console.WriteLine($"Abnormal_menstruation: {sampleData.Abnormal_menstruation}");
            Console.WriteLine($"Acidity: {sampleData.Acidity}");
            Console.WriteLine($"Acute_liver_failure: {sampleData.Acute_liver_failure}");
            Console.WriteLine($"Altered_sensorium: {sampleData.Altered_sensorium}");
            Console.WriteLine($"Anxiety: {sampleData.Anxiety}");
            Console.WriteLine($"Back_pain: {sampleData.Back_pain}");
            Console.WriteLine($"Belly_pain: {sampleData.Belly_pain}");
            Console.WriteLine($"Blackheads: {sampleData.Blackheads}");
            Console.WriteLine($"Bladder_discomfort: {sampleData.Bladder_discomfort}");
            Console.WriteLine($"Blister: {sampleData.Blister}");
            Console.WriteLine($"Blood_in_sputum: {sampleData.Blood_in_sputum}");
            Console.WriteLine($"Bloody_stool: {sampleData.Bloody_stool}");
            Console.WriteLine($"Blurred_and_distorted_vision: {sampleData.Blurred_and_distorted_vision}");
            Console.WriteLine($"Breathlessness: {sampleData.Breathlessness}");
            Console.WriteLine($"Brittle_nails: {sampleData.Brittle_nails}");
            Console.WriteLine($"Bruising: {sampleData.Bruising}");
            Console.WriteLine($"Burning_micturition: {sampleData.Burning_micturition}");
            Console.WriteLine($"Chest_pain: {sampleData.Chest_pain}");
            Console.WriteLine($"Chills: {sampleData.Chills}");
            Console.WriteLine($"Cold_hands_and_feets: {sampleData.Cold_hands_and_feets}");
            Console.WriteLine($"Coma: {sampleData.Coma}");
            Console.WriteLine($"Congestion: {sampleData.Congestion}");
            Console.WriteLine($"Constipation: {sampleData.Constipation}");
            Console.WriteLine($"Continuous_feel_of_urine: {sampleData.Continuous_feel_of_urine}");
            Console.WriteLine($"Continuous_sneezing: {sampleData.Continuous_sneezing}");
            Console.WriteLine($"Cough: {sampleData.Cough}");
            Console.WriteLine($"Cramps: {sampleData.Cramps}");
            Console.WriteLine($"Dark_urine: {sampleData.Dark_urine}");
            Console.WriteLine($"Dehydration: {sampleData.Dehydration}");
            Console.WriteLine($"Depression: {sampleData.Depression}");
            Console.WriteLine($"Diarrhoea: {sampleData.Diarrhoea}");
            Console.WriteLine($"Dischromic__patches: {sampleData.Dischromic__patches}");
            Console.WriteLine($"Distention_of_abdomen: {sampleData.Distention_of_abdomen}");
            Console.WriteLine($"Dizziness: {sampleData.Dizziness}");
            Console.WriteLine($"Drying_and_tingling_lips: {sampleData.Drying_and_tingling_lips}");
            Console.WriteLine($"Enlarged_thyroid: {sampleData.Enlarged_thyroid}");
            Console.WriteLine($"Excessive_hunger: {sampleData.Excessive_hunger}");
            Console.WriteLine($"Extra_marital_contacts: {sampleData.Extra_marital_contacts}");
            Console.WriteLine($"Family_history: {sampleData.Family_history}");
            Console.WriteLine($"Fast_heart_rate: {sampleData.Fast_heart_rate}");
            Console.WriteLine($"Fatigue: {sampleData.Fatigue}");
            Console.WriteLine($"Fluid_overload: {sampleData.Fluid_overload}");
            Console.WriteLine($"Foul_smell_of_urine: {sampleData.Foul_smell_of_urine}");
            Console.WriteLine($"Headache: {sampleData.Headache}");
            Console.WriteLine($"High_fever: {sampleData.High_fever}");
            Console.WriteLine($"Hip_joint_pain: {sampleData.Hip_joint_pain}");
            Console.WriteLine($"History_of_alcohol_consumption: {sampleData.History_of_alcohol_consumption}");
            Console.WriteLine($"Increased_appetite: {sampleData.Increased_appetite}");
            Console.WriteLine($"Indigestion: {sampleData.Indigestion}");
            Console.WriteLine($"Inflammatory_nails: {sampleData.Inflammatory_nails}");
            Console.WriteLine($"Internal_itching: {sampleData.Internal_itching}");
            Console.WriteLine($"Irregular_sugar_level: {sampleData.Irregular_sugar_level}");
            Console.WriteLine($"Irritability: {sampleData.Irritability}");
            Console.WriteLine($"Irritation_in_anus: {sampleData.Irritation_in_anus}");
            Console.WriteLine($"Itching: {sampleData.Itching}");
            Console.WriteLine($"Joint_pain: {sampleData.Joint_pain}");
            Console.WriteLine($"Knee_pain: {sampleData.Knee_pain}");
            Console.WriteLine($"Lack_of_concentration: {sampleData.Lack_of_concentration}");
            Console.WriteLine($"Lethargy: {sampleData.Lethargy}");
            Console.WriteLine($"Loss_of_appetite: {sampleData.Loss_of_appetite}");
            Console.WriteLine($"Loss_of_balance: {sampleData.Loss_of_balance}");
            Console.WriteLine($"Loss_of_smell: {sampleData.Loss_of_smell}");
            Console.WriteLine($"Malaise: {sampleData.Malaise}");
            Console.WriteLine($"Mild_fever: {sampleData.Mild_fever}");
            Console.WriteLine($"Mood_swings: {sampleData.Mood_swings}");
            Console.WriteLine($"Movement_stiffness: {sampleData.Movement_stiffness}");
            Console.WriteLine($"Mucoid_sputum: {sampleData.Mucoid_sputum}");
            Console.WriteLine($"Muscle_pain: {sampleData.Muscle_pain}");
            Console.WriteLine($"Muscle_wasting: {sampleData.Muscle_wasting}");
            Console.WriteLine($"Muscle_weakness: {sampleData.Muscle_weakness}");
            Console.WriteLine($"Nausea: {sampleData.Nausea}");
            Console.WriteLine($"Neck_pain: {sampleData.Neck_pain}");
            Console.WriteLine($"Nodal_skin_eruptions: {sampleData.Nodal_skin_eruptions}");
            Console.WriteLine($"Obesity: {sampleData.Obesity}");
            Console.WriteLine($"Pain_behind_the_eyes: {sampleData.Pain_behind_the_eyes}");
            Console.WriteLine($"Pain_during_bowel_movements: {sampleData.Pain_during_bowel_movements}");
            Console.WriteLine($"Pain_in_anal_region: {sampleData.Pain_in_anal_region}");
            Console.WriteLine($"Painful_walking: {sampleData.Painful_walking}");
            Console.WriteLine($"Palpitations: {sampleData.Palpitations}");
            Console.WriteLine($"Passage_of_gases: {sampleData.Passage_of_gases}");
            Console.WriteLine($"Patches_in_throat: {sampleData.Patches_in_throat}");
            Console.WriteLine($"Phlegm: {sampleData.Phlegm}");
            Console.WriteLine($"Polyuria: {sampleData.Polyuria}");
            Console.WriteLine($"Prominent_veins_on_calf: {sampleData.Prominent_veins_on_calf}");
            Console.WriteLine($"Puffy_face_and_eyes: {sampleData.Puffy_face_and_eyes}");
            Console.WriteLine($"Pus_filled_pimples: {sampleData.Pus_filled_pimples}");
            Console.WriteLine($"Receiving_blood_transfusion: {sampleData.Receiving_blood_transfusion}");
            Console.WriteLine($"Receiving_unsterile_injections: {sampleData.Receiving_unsterile_injections}");
            Console.WriteLine($"Red_sore_around_nose: {sampleData.Red_sore_around_nose}");
            Console.WriteLine($"Red_spots_over_body: {sampleData.Red_spots_over_body}");
            Console.WriteLine($"Redness_of_eyes: {sampleData.Redness_of_eyes}");
            Console.WriteLine($"Restlessness: {sampleData.Restlessness}");
            Console.WriteLine($"Runny_nose: {sampleData.Runny_nose}");
            Console.WriteLine($"Rusty_sputum: {sampleData.Rusty_sputum}");
            Console.WriteLine($"Scurring: {sampleData.Scurring}");
            Console.WriteLine($"Shivering: {sampleData.Shivering}");
            Console.WriteLine($"Silver_like_dusting: {sampleData.Silver_like_dusting}");
            Console.WriteLine($"Sinus_pressure: {sampleData.Sinus_pressure}");
            Console.WriteLine($"Skin_peeling: {sampleData.Skin_peeling}");
            Console.WriteLine($"Skin_rash: {sampleData.Skin_rash}");
            Console.WriteLine($"Slurred_speech: {sampleData.Slurred_speech}");
            Console.WriteLine($"Small_dents_in_nails: {sampleData.Small_dents_in_nails}");
            Console.WriteLine($"Spinning_movements: {sampleData.Spinning_movements}");
            Console.WriteLine($"Spotting__urination: {sampleData.Spotting__urination}");
            Console.WriteLine($"Stiff_neck: {sampleData.Stiff_neck}");
            Console.WriteLine($"Stomach_bleeding: {sampleData.Stomach_bleeding}");
            Console.WriteLine($"Stomach_pain: {sampleData.Stomach_pain}");
            Console.WriteLine($"Sunken_eyes: {sampleData.Sunken_eyes}");
            Console.WriteLine($"Sweating: {sampleData.Sweating}");
            Console.WriteLine($"Swelled_lymph_nodes: {sampleData.Swelled_lymph_nodes}");
            Console.WriteLine($"Swelling_joints: {sampleData.Swelling_joints}");
            Console.WriteLine($"Swelling_of_stomach: {sampleData.Swelling_of_stomach}");
            Console.WriteLine($"Swollen_blood_vessels: {sampleData.Swollen_blood_vessels}");
            Console.WriteLine($"Swollen_extremeties: {sampleData.Swollen_extremeties}");
            Console.WriteLine($"Swollen_legs: {sampleData.Swollen_legs}");
            Console.WriteLine($"Throat_irritation: {sampleData.Throat_irritation}");
            Console.WriteLine($"Toxic_look__typhos_: {sampleData.Toxic_look__typhos_}");
            Console.WriteLine($"Ulcers_on_tongue: {sampleData.Ulcers_on_tongue}");
            Console.WriteLine($"Unsteadiness: {sampleData.Unsteadiness}");
            Console.WriteLine($"Visual_disturbances: {sampleData.Visual_disturbances}");
            Console.WriteLine($"Vomiting: {sampleData.Vomiting}");
            Console.WriteLine($"Watering_from_eyes: {sampleData.Watering_from_eyes}");
            Console.WriteLine($"Weakness_in_limbs: {sampleData.Weakness_in_limbs}");
            Console.WriteLine($"Weakness_of_one_body_side: {sampleData.Weakness_of_one_body_side}");
            Console.WriteLine($"Weight_gain: {sampleData.Weight_gain}");
            Console.WriteLine($"Weight_loss: {sampleData.Weight_loss}");
            Console.WriteLine($"Yellow_crust_ooze: {sampleData.Yellow_crust_ooze}");
            Console.WriteLine($"Yellow_urine: {sampleData.Yellow_urine}");
            Console.WriteLine($"Yellowing_of_eyes: {sampleData.Yellowing_of_eyes}");
            Console.WriteLine($"Yellowish_skin: {sampleData.Yellowish_skin}");
            Console.WriteLine($"\n\nPredicted Disease value {predictionResult.Prediction} \nPredicted Disease scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");

                        Console.ReadKey();
        }
    }
}
