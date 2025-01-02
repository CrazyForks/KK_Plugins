﻿using MessagePack;
using System;

namespace KK_Plugins.DynamicBoneEditor
{
    [Serializable]
    [MessagePackObject]
    public class DynamicBoneData
    {
        [Key(nameof(CoordinateIndex))] public int CoordinateIndex;
        [Key(nameof(Slot))] public int Slot;
        [Key(nameof(BoneName))] public string BoneName;

        [Key(nameof(FreezeAxis))] public DynamicBone.FreezeAxis? FreezeAxis = null;
        [Key(nameof(Weight))] public float? Weight = null;
        [Key(nameof(Damping))] public float? Damping = null;
        [Key(nameof(Elasticity))] public float? Elasticity = null;
        [Key(nameof(Stiffness))] public float? Stiffness = null;
        [Key(nameof(Inertia))] public float? Inertia = null;
        [Key(nameof(Radius))] public float? Radius = null;

        [Key(nameof(FreezeAxisOriginal))] public DynamicBone.FreezeAxis? FreezeAxisOriginal;
        [Key(nameof(WeightOriginal))] public float? WeightOriginal;
        [Key(nameof(DampingOriginal))] public float? DampingOriginal;
        [Key(nameof(ElasticityOriginal))] public float? ElasticityOriginal;
        [Key(nameof(StiffnessOriginal))] public float? StiffnessOriginal;
        [Key(nameof(InertiaOriginal))] public float? InertiaOriginal;
        [Key(nameof(RadiusOriginal))] public float? RadiusOriginal;

        public DynamicBoneData(int coordinateIndex, int slot, string boneName)
        {
            CoordinateIndex = coordinateIndex;
            Slot = slot;
            BoneName = boneName;
        }

        public void CopyTo(DynamicBoneData target)
        {
            target.FreezeAxis = FreezeAxis;
            target.Weight = Weight;
            target.Damping = Damping;
            target.Elasticity = Elasticity;
            target.Stiffness = Stiffness;
            target.Inertia = Inertia;
            target.Radius = Radius;
            target.FreezeAxisOriginal = FreezeAxisOriginal;
            target.WeightOriginal = WeightOriginal;
            target.DampingOriginal = DampingOriginal;
            target.ElasticityOriginal = ElasticityOriginal;
            target.StiffnessOriginal = StiffnessOriginal;
            target.InertiaOriginal = InertiaOriginal;
            target.RadiusOriginal = RadiusOriginal;
        }

        public DynamicBone.FreezeAxis GetFreezeAxisOriginal(DynamicBone dynamicBone)
        {
            if (FreezeAxisOriginal == null)
                FreezeAxisOriginal = dynamicBone.m_FreezeAxis;
            return (DynamicBone.FreezeAxis)FreezeAxisOriginal;
        }

        public float GetWeightOriginal(DynamicBone dynamicBone)
        {
            if (WeightOriginal == null)
                WeightOriginal = dynamicBone.GetWeight();
            return (float)WeightOriginal;
        }

        public float GetDampingOriginal(DynamicBone dynamicBone)
        {
            if (DampingOriginal == null)
                DampingOriginal = dynamicBone.m_Damping;
            return (float)DampingOriginal;
        }

        public float GetElasticityOriginal(DynamicBone dynamicBone)
        {
            if (ElasticityOriginal == null)
                ElasticityOriginal = dynamicBone.m_Elasticity;
            return (float)ElasticityOriginal;
        }

        public float GetStiffnessOriginal(DynamicBone dynamicBone)
        {
            if (StiffnessOriginal == null)
                StiffnessOriginal = dynamicBone.m_Stiffness;
            return (float)StiffnessOriginal;
        }

        public float GetInertiaOriginal(DynamicBone dynamicBone)
        {
            if (InertiaOriginal == null)
                InertiaOriginal = dynamicBone.m_Inert;
            return (float)InertiaOriginal;
        }

        public float GetRadiusOriginal(DynamicBone dynamicBone)
        {
            if (RadiusOriginal == null)
                RadiusOriginal = dynamicBone.m_Radius;
            return (float)RadiusOriginal;
        }
    }
}
