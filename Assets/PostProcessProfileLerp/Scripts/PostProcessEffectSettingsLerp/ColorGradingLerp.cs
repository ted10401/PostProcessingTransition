﻿using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ColorGradingLerp : PostProcessEffectSettingsLerp<ColorGrading>
{
    public Vector2 toneCurveToeStrength;
    public Vector2 toneCurveToeLength;
    public Vector2 toneCurveShoulderStrength;
    public Vector2 toneCurveShoulderLength;
    public Vector2 toneCurveShoulderAngle;
    public Vector2 toneCurveGamma;
    public Vector2 ldrLutContribution;
    public Vector2 temperature;
    public Vector2 tint;
    public Color fromColorFilter;
    public Color toColorFilter;
    public Vector2 hueShift;
    public Vector2 saturation;
    public Vector2 brightness;
    public Vector2 postExposure;
    public Vector2 contrast;
    public Vector2 mixerRedOutRedIn;
    public Vector2 mixerRedOutGreenIn;
    public Vector2 mixerRedOutBlueIn;
    public Vector2 mixerGreenOutRedIn;
    public Vector2 mixerGreenOutGreenIn;
    public Vector2 mixerGreenOutBlueIn;
    public Vector2 mixerBlueOutRedIn;
    public Vector2 mixerBlueOutGreenIn;
    public Vector2 mixerBlueOutBlueIn;
    public Vector4 fromLift;
    public Vector4 toLift;
    public Vector4 fromGamma;
    public Vector4 toGamma;
    public Vector4 fromGain;
    public Vector4 toGain;

    public ColorGradingLerp(PostProcessProfile from, PostProcessProfile to, PostProcessProfile temp) : base(from, to, temp)
    {
    }

    public override void InitializeParameters()
    {
        //toneCurveToeStrength
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.toneCurveToeStrength.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.toneCurveToeStrength.overrideState))
        {
            m_tempSettings.toneCurveToeStrength.overrideState = true;
        }
        else
        {
            m_tempSettings.toneCurveToeStrength.overrideState = false;
        }
        toneCurveToeStrength.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.toneCurveToeStrength.overrideState ? m_fromSettings.toneCurveToeStrength.value : m_tempSettings.toneCurveToeStrength.value;
        toneCurveToeStrength.y = m_toSettings != null && m_toSettings.active && m_toSettings.toneCurveToeStrength.overrideState ? m_toSettings.toneCurveToeStrength.value : m_tempSettings.toneCurveToeStrength.value;

        //toneCurveToeLength
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.toneCurveToeLength.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.toneCurveToeLength.overrideState))
        {
            m_tempSettings.toneCurveToeLength.overrideState = true;
        }
        else
        {
            m_tempSettings.toneCurveToeLength.overrideState = false;
        }
        toneCurveToeLength.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.toneCurveToeLength.overrideState ? m_fromSettings.toneCurveToeLength.value : m_tempSettings.toneCurveToeLength.value;
        toneCurveToeLength.y = m_toSettings != null && m_toSettings.active && m_toSettings.toneCurveToeLength.overrideState ? m_toSettings.toneCurveToeLength.value : m_tempSettings.toneCurveToeLength.value;

        //toneCurveShoulderStrength
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.toneCurveShoulderStrength.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.toneCurveShoulderStrength.overrideState))
        {
            m_tempSettings.toneCurveShoulderStrength.overrideState = true;
        }
        else
        {
            m_tempSettings.toneCurveShoulderStrength.overrideState = false;
        }
        toneCurveShoulderStrength.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.toneCurveShoulderStrength.overrideState ? m_fromSettings.toneCurveShoulderStrength.value : m_tempSettings.toneCurveShoulderStrength.value;
        toneCurveShoulderStrength.y = m_toSettings != null && m_toSettings.active && m_toSettings.toneCurveShoulderStrength.overrideState ? m_toSettings.toneCurveShoulderStrength.value : m_tempSettings.toneCurveShoulderStrength.value;

        //toneCurveShoulderLength
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.toneCurveShoulderLength.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.toneCurveShoulderLength.overrideState))
        {
            m_tempSettings.toneCurveShoulderLength.overrideState = true;
        }
        else
        {
            m_tempSettings.toneCurveShoulderLength.overrideState = false;
        }
        toneCurveShoulderLength.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.toneCurveShoulderLength.overrideState ? m_fromSettings.toneCurveShoulderLength.value : m_tempSettings.toneCurveShoulderLength.value;
        toneCurveShoulderLength.y = m_toSettings != null && m_toSettings.active && m_toSettings.toneCurveShoulderLength.overrideState ? m_toSettings.toneCurveShoulderLength.value : m_tempSettings.toneCurveShoulderLength.value;

        //toneCurveShoulderAngle
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.toneCurveShoulderAngle.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.toneCurveShoulderAngle.overrideState))
        {
            m_tempSettings.toneCurveShoulderAngle.overrideState = true;
        }
        else
        {
            m_tempSettings.toneCurveShoulderAngle.overrideState = false;
        }
        toneCurveShoulderAngle.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.toneCurveShoulderAngle.overrideState ? m_fromSettings.toneCurveShoulderAngle.value : m_tempSettings.toneCurveShoulderAngle.value;
        toneCurveShoulderAngle.y = m_toSettings != null && m_toSettings.active && m_toSettings.toneCurveShoulderAngle.overrideState ? m_toSettings.toneCurveShoulderAngle.value : m_tempSettings.toneCurveShoulderAngle.value;

        //toneCurveGamma
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.toneCurveGamma.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.toneCurveGamma.overrideState))
        {
            m_tempSettings.toneCurveGamma.overrideState = true;
        }
        else
        {
            m_tempSettings.toneCurveGamma.overrideState = false;
        }
        toneCurveGamma.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.toneCurveGamma.overrideState ? m_fromSettings.toneCurveGamma.value : m_tempSettings.toneCurveGamma.value;
        toneCurveGamma.y = m_toSettings != null && m_toSettings.active && m_toSettings.toneCurveGamma.overrideState ? m_toSettings.toneCurveGamma.value : m_tempSettings.toneCurveGamma.value;

        //ldrLutContribution
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.ldrLutContribution.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.ldrLutContribution.overrideState))
        {
            m_tempSettings.ldrLutContribution.overrideState = true;
        }
        else
        {
            m_tempSettings.ldrLutContribution.overrideState = false;
        }
        ldrLutContribution.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.ldrLutContribution.overrideState ? m_fromSettings.ldrLutContribution.value : m_tempSettings.ldrLutContribution.value;
        ldrLutContribution.y = m_toSettings != null && m_toSettings.active && m_toSettings.ldrLutContribution.overrideState ? m_toSettings.ldrLutContribution.value : m_tempSettings.ldrLutContribution.value;

        //temperature
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.temperature.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.temperature.overrideState))
        {
            m_tempSettings.temperature.overrideState = true;
        }
        else
        {
            m_tempSettings.temperature.overrideState = false;
        }
        temperature.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.temperature.overrideState ? m_fromSettings.temperature.value : m_tempSettings.temperature.value;
        temperature.y = m_toSettings != null && m_toSettings.active && m_toSettings.temperature.overrideState ? m_toSettings.temperature.value : m_tempSettings.temperature.value;

        //tint
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.tint.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.tint.overrideState))
        {
            m_tempSettings.tint.overrideState = true;
        }
        else
        {
            m_tempSettings.tint.overrideState = false;
        }
        tint.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.tint.overrideState ? m_fromSettings.tint.value : m_tempSettings.tint.value;
        tint.y = m_toSettings != null && m_toSettings.active && m_toSettings.tint.overrideState ? m_toSettings.tint.value : m_tempSettings.tint.value;

        //colorFilter
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.colorFilter.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.colorFilter.overrideState))
        {
            m_tempSettings.colorFilter.overrideState = true;
        }
        else
        {
            m_tempSettings.colorFilter.overrideState = false;
        }
        fromColorFilter = m_fromSettings != null && m_fromSettings.active && m_fromSettings.colorFilter.overrideState ? m_fromSettings.colorFilter.value : m_tempSettings.colorFilter.value;
        toColorFilter = m_toSettings != null && m_toSettings.active && m_toSettings.colorFilter.overrideState ? m_toSettings.colorFilter.value : m_tempSettings.colorFilter.value;

        //hueShift
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.hueShift.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.hueShift.overrideState))
        {
            m_tempSettings.hueShift.overrideState = true;
        }
        else
        {
            m_tempSettings.hueShift.overrideState = false;
        }
        hueShift.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.hueShift.overrideState ? m_fromSettings.hueShift.value : m_tempSettings.hueShift.value;
        hueShift.y = m_toSettings != null && m_toSettings.active && m_toSettings.hueShift.overrideState ? m_toSettings.hueShift.value : m_tempSettings.hueShift.value;

        //saturation
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.saturation.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.saturation.overrideState))
        {
            m_tempSettings.saturation.overrideState = true;
        }
        else
        {
            m_tempSettings.saturation.overrideState = false;
        }
        saturation.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.saturation.overrideState ? m_fromSettings.saturation.value : m_tempSettings.saturation.value;
        saturation.y = m_toSettings != null && m_toSettings.active && m_toSettings.saturation.overrideState ? m_toSettings.saturation.value : m_tempSettings.saturation.value;

        //brightness
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.brightness.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.brightness.overrideState))
        {
            m_tempSettings.brightness.overrideState = true;
        }
        else
        {
            m_tempSettings.brightness.overrideState = false;
        }
        brightness.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.brightness.overrideState ? m_fromSettings.brightness.value : m_tempSettings.brightness.value;
        brightness.y = m_toSettings != null && m_toSettings.active && m_toSettings.brightness.overrideState ? m_toSettings.brightness.value : m_tempSettings.brightness.value;

        //postExposure
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.postExposure.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.postExposure.overrideState))
        {
            m_tempSettings.postExposure.overrideState = true;
        }
        else
        {
            m_tempSettings.postExposure.overrideState = false;
        }
        postExposure.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.postExposure.overrideState ? m_fromSettings.postExposure.value : m_tempSettings.postExposure.value;
        postExposure.y = m_toSettings != null && m_toSettings.active && m_toSettings.postExposure.overrideState ? m_toSettings.postExposure.value : m_tempSettings.postExposure.value;

        //contrast
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.contrast.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.contrast.overrideState))
        {
            m_tempSettings.contrast.overrideState = true;
        }
        else
        {
            m_tempSettings.contrast.overrideState = false;
        }
        contrast.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.contrast.overrideState ? m_fromSettings.contrast.value : m_tempSettings.contrast.value;
        contrast.y = m_toSettings != null && m_toSettings.active && m_toSettings.contrast.overrideState ? m_toSettings.contrast.value : m_tempSettings.contrast.value;

        //mixerRedOutRedIn
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.mixerRedOutRedIn.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.mixerRedOutRedIn.overrideState))
        {
            m_tempSettings.mixerRedOutRedIn.overrideState = true;
        }
        else
        {
            m_tempSettings.mixerRedOutRedIn.overrideState = false;
        }
        mixerRedOutRedIn.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.mixerRedOutRedIn.overrideState ? m_fromSettings.mixerRedOutRedIn.value : m_tempSettings.mixerRedOutRedIn.value;
        mixerRedOutRedIn.y = m_toSettings != null && m_toSettings.active && m_toSettings.mixerRedOutRedIn.overrideState ? m_toSettings.mixerRedOutRedIn.value : m_tempSettings.mixerRedOutRedIn.value;

        //mixerRedOutGreenIn
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.mixerRedOutGreenIn.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.mixerRedOutGreenIn.overrideState))
        {
            m_tempSettings.mixerRedOutGreenIn.overrideState = true;
        }
        else
        {
            m_tempSettings.mixerRedOutGreenIn.overrideState = false;
        }
        mixerRedOutGreenIn.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.mixerRedOutGreenIn.overrideState ? m_fromSettings.mixerRedOutGreenIn.value : m_tempSettings.mixerRedOutGreenIn.value;
        mixerRedOutGreenIn.y = m_toSettings != null && m_toSettings.active && m_toSettings.mixerRedOutGreenIn.overrideState ? m_toSettings.mixerRedOutGreenIn.value : m_tempSettings.mixerRedOutGreenIn.value;

        //mixerRedOutBlueIn
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.mixerRedOutBlueIn.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.mixerRedOutBlueIn.overrideState))
        {
            m_tempSettings.mixerRedOutBlueIn.overrideState = true;
        }
        else
        {
            m_tempSettings.mixerRedOutBlueIn.overrideState = false;
        }
        mixerRedOutBlueIn.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.mixerRedOutBlueIn.overrideState ? m_fromSettings.mixerRedOutBlueIn.value : m_tempSettings.mixerRedOutBlueIn.value;
        mixerRedOutBlueIn.y = m_toSettings != null && m_toSettings.active && m_toSettings.mixerRedOutBlueIn.overrideState ? m_toSettings.mixerRedOutBlueIn.value : m_tempSettings.mixerRedOutBlueIn.value;

        //mixerGreenOutRedIn
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.mixerGreenOutRedIn.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.mixerGreenOutRedIn.overrideState))
        {
            m_tempSettings.mixerGreenOutRedIn.overrideState = true;
        }
        else
        {
            m_tempSettings.mixerGreenOutRedIn.overrideState = false;
        }
        mixerGreenOutRedIn.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.mixerGreenOutRedIn.overrideState ? m_fromSettings.mixerGreenOutRedIn.value : m_tempSettings.mixerGreenOutRedIn.value;
        mixerGreenOutRedIn.y = m_toSettings != null && m_toSettings.active && m_toSettings.mixerGreenOutRedIn.overrideState ? m_toSettings.mixerGreenOutRedIn.value : m_tempSettings.mixerGreenOutRedIn.value;

        //mixerGreenOutGreenIn
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.mixerGreenOutGreenIn.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.mixerGreenOutGreenIn.overrideState))
        {
            m_tempSettings.mixerGreenOutGreenIn.overrideState = true;
        }
        else
        {
            m_tempSettings.mixerGreenOutGreenIn.overrideState = false;
        }
        mixerGreenOutGreenIn.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.mixerGreenOutGreenIn.overrideState ? m_fromSettings.mixerGreenOutGreenIn.value : m_tempSettings.mixerGreenOutGreenIn.value;
        mixerGreenOutGreenIn.y = m_toSettings != null && m_toSettings.active && m_toSettings.mixerGreenOutGreenIn.overrideState ? m_toSettings.mixerGreenOutGreenIn.value : m_tempSettings.mixerGreenOutGreenIn.value;

        //mixerGreenOutBlueIn
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.mixerGreenOutBlueIn.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.mixerGreenOutBlueIn.overrideState))
        {
            m_tempSettings.mixerGreenOutBlueIn.overrideState = true;
        }
        else
        {
            m_tempSettings.mixerGreenOutBlueIn.overrideState = false;
        }
        mixerGreenOutBlueIn.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.mixerGreenOutBlueIn.overrideState ? m_fromSettings.mixerGreenOutBlueIn.value : m_tempSettings.mixerGreenOutBlueIn.value;
        mixerGreenOutBlueIn.y = m_toSettings != null && m_toSettings.active && m_toSettings.mixerGreenOutBlueIn.overrideState ? m_toSettings.mixerGreenOutBlueIn.value : m_tempSettings.mixerGreenOutBlueIn.value;

        //mixerBlueOutRedIn
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.mixerBlueOutRedIn.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.mixerBlueOutRedIn.overrideState))
        {
            m_tempSettings.mixerBlueOutRedIn.overrideState = true;
        }
        else
        {
            m_tempSettings.mixerBlueOutRedIn.overrideState = false;
        }
        mixerBlueOutRedIn.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.mixerBlueOutRedIn.overrideState ? m_fromSettings.mixerBlueOutRedIn.value : m_tempSettings.mixerBlueOutRedIn.value;
        mixerBlueOutRedIn.y = m_toSettings != null && m_toSettings.active && m_toSettings.mixerBlueOutRedIn.overrideState ? m_toSettings.mixerBlueOutRedIn.value : m_tempSettings.mixerBlueOutRedIn.value;

        //mixerBlueOutGreenIn
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.mixerBlueOutGreenIn.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.mixerBlueOutGreenIn.overrideState))
        {
            m_tempSettings.mixerBlueOutGreenIn.overrideState = true;
        }
        else
        {
            m_tempSettings.mixerBlueOutGreenIn.overrideState = false;
        }
        mixerBlueOutGreenIn.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.mixerBlueOutGreenIn.overrideState ? m_fromSettings.mixerBlueOutGreenIn.value : m_tempSettings.mixerBlueOutGreenIn.value;
        mixerBlueOutGreenIn.y = m_toSettings != null && m_toSettings.active && m_toSettings.mixerBlueOutGreenIn.overrideState ? m_toSettings.mixerBlueOutGreenIn.value : m_tempSettings.mixerBlueOutGreenIn.value;

        //mixerBlueOutBlueIn
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.mixerBlueOutBlueIn.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.mixerBlueOutBlueIn.overrideState))
        {
            m_tempSettings.mixerBlueOutBlueIn.overrideState = true;
        }
        else
        {
            m_tempSettings.mixerBlueOutBlueIn.overrideState = false;
        }
        mixerBlueOutBlueIn.x = m_fromSettings != null && m_fromSettings.active && m_fromSettings.mixerBlueOutBlueIn.overrideState ? m_fromSettings.mixerBlueOutBlueIn.value : m_tempSettings.mixerBlueOutBlueIn.value;
        mixerBlueOutBlueIn.y = m_toSettings != null && m_toSettings.active && m_toSettings.mixerBlueOutBlueIn.overrideState ? m_toSettings.mixerBlueOutBlueIn.value : m_tempSettings.mixerBlueOutBlueIn.value;

        //lift
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.lift.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.lift.overrideState))
        {
            m_tempSettings.lift.overrideState = true;
        }
        else
        {
            m_tempSettings.lift.overrideState = false;
        }
        fromLift = m_fromSettings != null && m_fromSettings.active && m_fromSettings.lift.overrideState ? m_fromSettings.lift.value : m_tempSettings.lift.value;
        toLift = m_toSettings != null && m_toSettings.active && m_toSettings.lift.overrideState ? m_toSettings.lift.value : m_tempSettings.lift.value;

        //gamma
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.gamma.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.gamma.overrideState))
        {
            m_tempSettings.gamma.overrideState = true;
        }
        else
        {
            m_tempSettings.gamma.overrideState = false;
        }
        fromGamma = m_fromSettings != null && m_fromSettings.active && m_fromSettings.gamma.overrideState ? m_fromSettings.gamma.value : m_tempSettings.gamma.value;
        toGamma = m_toSettings != null && m_toSettings.active && m_toSettings.gamma.overrideState ? m_toSettings.gamma.value : m_tempSettings.gamma.value;

        //gain
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.gain.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.gain.overrideState))
        {
            m_tempSettings.gain.overrideState = true;
        }
        else
        {
            m_tempSettings.gain.overrideState = false;
        }
        fromGain = m_fromSettings != null && m_fromSettings.active && m_fromSettings.gain.overrideState ? m_fromSettings.gain.value : m_tempSettings.gain.value;
        toGain = m_toSettings != null && m_toSettings.active && m_toSettings.gain.overrideState ? m_toSettings.gain.value : m_tempSettings.gain.value;
    }

    public override void Lerp(float t)
    {
        if (!IsValid())
        {
            return;
        }

        //gradingMode
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.gradingMode.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.gradingMode.overrideState))
        {
            m_tempSettings.gradingMode.overrideState = true;

            if(t < 0.5f)
            {
                if(m_fromSettings != null)
                {
                    m_tempSettings.gradingMode.value = m_fromSettings.gradingMode.value;
                }
                else
                {
                    m_tempSettings.gradingMode.value = GradingMode.HighDefinitionRange;
                }
            }
            else
            {
                if (m_toSettings != null)
                {
                    m_tempSettings.gradingMode.value = m_toSettings.gradingMode.value;
                }
                else
                {
                    m_tempSettings.gradingMode.value = GradingMode.HighDefinitionRange;
                }
            }
        }
        else
        {
            m_tempSettings.gradingMode.overrideState = false;
        }

        //externalLut
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.externalLut.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.externalLut.overrideState))
        {
            m_tempSettings.externalLut.overrideState = true;

            if (t < 0.5f)
            {
                if (m_fromSettings != null)
                {
                    m_tempSettings.externalLut.value = m_fromSettings.externalLut.value;
                }
                else
                {
                    m_tempSettings.externalLut.value = null;
                }
            }
            else
            {
                if (m_toSettings != null)
                {
                    m_tempSettings.externalLut.value = m_toSettings.externalLut.value;
                }
                else
                {
                    m_tempSettings.externalLut.value = null;
                }
            }
        }
        else
        {
            m_tempSettings.externalLut.overrideState = false;
        }

        //tonemapper
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.tonemapper.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.tonemapper.overrideState))
        {
            m_tempSettings.tonemapper.overrideState = true;

            if (t < 0.5f)
            {
                if (m_fromSettings != null)
                {
                    m_tempSettings.tonemapper.value = m_fromSettings.tonemapper.value;
                }
                else
                {
                    m_tempSettings.tonemapper.value = Tonemapper.None;
                }
            }
            else
            {
                if (m_toSettings != null)
                {
                    m_tempSettings.tonemapper.value = m_toSettings.tonemapper.value;
                }
                else
                {
                    m_tempSettings.tonemapper.value = Tonemapper.None;
                }
            }
        }
        else
        {
            m_tempSettings.tonemapper.overrideState = false;
        }

        //toneCurveToeStrength
        m_tempSettings.toneCurveToeStrength.value = Mathf.Lerp(toneCurveToeStrength.x, toneCurveToeStrength.y, t);

        //toneCurveToeLength
        m_tempSettings.toneCurveToeLength.value = Mathf.Lerp(toneCurveToeLength.x, toneCurveToeLength.y, t);

        //toneCurveShoulderStrength
        m_tempSettings.toneCurveShoulderStrength.value = Mathf.Lerp(toneCurveShoulderStrength.x, toneCurveShoulderStrength.y, t);

        //toneCurveShoulderLength
        m_tempSettings.toneCurveShoulderLength.value = Mathf.Lerp(toneCurveShoulderLength.x, toneCurveShoulderLength.y, t);

        //toneCurveShoulderAngle
        m_tempSettings.toneCurveShoulderAngle.value = Mathf.Lerp(toneCurveShoulderAngle.x, toneCurveShoulderAngle.y, t);

        //toneCurveGamma
        m_tempSettings.toneCurveGamma.value = Mathf.Lerp(toneCurveGamma.x, toneCurveGamma.y, t);

        //ldrLut
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.ldrLut.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.ldrLut.overrideState))
        {
            m_tempSettings.ldrLut.overrideState = true;

            if (t < 0.5f)
            {
                if (m_fromSettings != null)
                {
                    m_tempSettings.ldrLut.value = m_fromSettings.ldrLut.value;
                }
                else
                {
                    m_tempSettings.ldrLut.value = null;
                }
            }
            else
            {
                if (m_toSettings != null)
                {
                    m_tempSettings.ldrLut.value = m_toSettings.ldrLut.value;
                }
                else
                {
                    m_tempSettings.ldrLut.value = null;
                }
            }
        }
        else
        {
            m_tempSettings.ldrLut.overrideState = false;
        }

        //ldrLutContribution
        m_tempSettings.ldrLutContribution.value = Mathf.Lerp(ldrLutContribution.x, ldrLutContribution.y, t);

        //temperature
        m_tempSettings.temperature.value = Mathf.Lerp(temperature.x, temperature.y, t);

        //tint
        m_tempSettings.tint.value = Mathf.Lerp(tint.x, tint.y, t);

        //colorFilter
        m_tempSettings.colorFilter.value = Color.Lerp(fromColorFilter, toColorFilter, t);

        //hueShift
        m_tempSettings.hueShift.value = Mathf.Lerp(hueShift.x, hueShift.y, t);

        //saturation
        m_tempSettings.saturation.value = Mathf.Lerp(saturation.x, saturation.y, t);

        //brightness
        m_tempSettings.brightness.value = Mathf.Lerp(brightness.x, brightness.y, t);

        //postExposure
        m_tempSettings.postExposure.value = Mathf.Lerp(postExposure.x, postExposure.y, t);

        //contrast
        m_tempSettings.contrast.value = Mathf.Lerp(contrast.x, contrast.y, t);

        //mixerRedOutRedIn
        m_tempSettings.mixerRedOutRedIn.value = Mathf.Lerp(mixerRedOutRedIn.x, mixerRedOutRedIn.y, t);

        //mixerRedOutGreenIn
        m_tempSettings.mixerRedOutGreenIn.value = Mathf.Lerp(mixerRedOutGreenIn.x, mixerRedOutGreenIn.y, t);

        //mixerRedOutBlueIn
        m_tempSettings.mixerRedOutBlueIn.value = Mathf.Lerp(mixerRedOutBlueIn.x, mixerRedOutBlueIn.y, t);

        //mixerGreenOutRedIn
        m_tempSettings.mixerGreenOutRedIn.value = Mathf.Lerp(mixerGreenOutRedIn.x, mixerGreenOutRedIn.y, t);

        //mixerGreenOutGreenIn
        m_tempSettings.mixerGreenOutGreenIn.value = Mathf.Lerp(mixerGreenOutGreenIn.x, mixerGreenOutGreenIn.y, t);

        //mixerGreenOutBlueIn
        m_tempSettings.mixerGreenOutBlueIn.value = Mathf.Lerp(mixerGreenOutBlueIn.x, mixerGreenOutBlueIn.y, t);

        //mixerBlueOutRedIn
        m_tempSettings.mixerBlueOutRedIn.value = Mathf.Lerp(mixerBlueOutRedIn.x, mixerBlueOutRedIn.y, t);

        //mixerBlueOutGreenIn
        m_tempSettings.mixerBlueOutGreenIn.value = Mathf.Lerp(mixerBlueOutGreenIn.x, mixerBlueOutGreenIn.y, t);

        //mixerBlueOutBlueIn
        m_tempSettings.mixerBlueOutBlueIn.value = Mathf.Lerp(mixerBlueOutBlueIn.x, mixerBlueOutBlueIn.y, t);

        //lift
        m_tempSettings.lift.value = Vector4.Lerp(fromLift, toLift, t);

        //gamma
        m_tempSettings.gamma.value = Vector4.Lerp(fromGamma, toGamma, t);

        //gain
        m_tempSettings.gain.value = Vector4.Lerp(fromGain, toGain, t);

        //masterCurve
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.masterCurve.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.masterCurve.overrideState))
        {
            m_tempSettings.masterCurve.overrideState = true;

            if (t < 0.5f)
            {
                if (m_fromSettings != null)
                {
                    m_tempSettings.masterCurve.value = m_fromSettings.masterCurve.value;
                }
                else
                {
                    m_tempSettings.masterCurve.value = new Spline(new AnimationCurve((Keyframe[])new Keyframe[2] {
                    new Keyframe (0f, 0f, 1f, 1f),
                    new Keyframe (1f, 1f, 1f, 1f)
                    }), 0f, false, new Vector2(0f, 1f));
                }
            }
            else
            {
                if (m_toSettings != null)
                {
                    m_tempSettings.masterCurve.value = m_toSettings.masterCurve.value;
                }
                else
                {
                    m_tempSettings.masterCurve.value = new Spline(new AnimationCurve((Keyframe[])new Keyframe[2] {
                    new Keyframe (0f, 0f, 1f, 1f),
                    new Keyframe (1f, 1f, 1f, 1f)
                    }), 0f, false, new Vector2(0f, 1f));
                }
            }
        }
        else
        {
            m_tempSettings.masterCurve.overrideState = false;
        }

        //redCurve
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.redCurve.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.redCurve.overrideState))
        {
            m_tempSettings.redCurve.overrideState = true;

            if (t < 0.5f)
            {
                if (m_fromSettings != null)
                {
                    m_tempSettings.redCurve.value = m_fromSettings.redCurve.value;
                }
                else
                {
                    m_tempSettings.redCurve.value = new Spline(new AnimationCurve((Keyframe[])new Keyframe[2] {
                    new Keyframe (0f, 0f, 1f, 1f),
                    new Keyframe (1f, 1f, 1f, 1f)
                    }), 0f, false, new Vector2(0f, 1f));
                }
            }
            else
            {
                if (m_toSettings != null)
                {
                    m_tempSettings.redCurve.value = m_toSettings.redCurve.value;
                }
                else
                {
                    m_tempSettings.redCurve.value = new Spline(new AnimationCurve((Keyframe[])new Keyframe[2] {
                    new Keyframe (0f, 0f, 1f, 1f),
                    new Keyframe (1f, 1f, 1f, 1f)
                    }), 0f, false, new Vector2(0f, 1f));
                }
            }
        }
        else
        {
            m_tempSettings.redCurve.overrideState = false;
        }

        //greenCurve
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.greenCurve.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.greenCurve.overrideState))
        {
            m_tempSettings.greenCurve.overrideState = true;

            if (t < 0.5f)
            {
                if (m_fromSettings != null)
                {
                    m_tempSettings.greenCurve.value = m_fromSettings.greenCurve.value;
                }
                else
                {
                    m_tempSettings.greenCurve.value = new Spline(new AnimationCurve((Keyframe[])new Keyframe[2] {
                        new Keyframe (0f, 0f, 1f, 1f),
                        new Keyframe (1f, 1f, 1f, 1f)
                    }), 0f, false, new Vector2(0f, 1f));
                }
            }
            else
            {
                if (m_toSettings != null)
                {
                    m_tempSettings.greenCurve.value = m_toSettings.greenCurve.value;
                }
                else
                {
                    m_tempSettings.greenCurve.value = new Spline(new AnimationCurve((Keyframe[])new Keyframe[2] {
                        new Keyframe (0f, 0f, 1f, 1f),
                        new Keyframe (1f, 1f, 1f, 1f)
                    }), 0f, false, new Vector2(0f, 1f));
                }
            }
        }
        else
        {
            m_tempSettings.greenCurve.overrideState = false;
        }

        //blueCurve
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.blueCurve.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.blueCurve.overrideState))
        {
            m_tempSettings.blueCurve.overrideState = true;

            if (t < 0.5f)
            {
                if (m_fromSettings != null)
                {
                    m_tempSettings.blueCurve.value = m_fromSettings.blueCurve.value;
                }
                else
                {
                    m_tempSettings.blueCurve.value = new Spline(new AnimationCurve((Keyframe[])new Keyframe[2] {
                        new Keyframe (0f, 0f, 1f, 1f),
                        new Keyframe (1f, 1f, 1f, 1f)
                    }), 0f, false, new Vector2(0f, 1f));
                }
            }
            else
            {
                if (m_toSettings != null)
                {
                    m_tempSettings.blueCurve.value = m_toSettings.blueCurve.value;
                }
                else
                {
                    m_tempSettings.blueCurve.value = new Spline(new AnimationCurve((Keyframe[])new Keyframe[2] {
                        new Keyframe (0f, 0f, 1f, 1f),
                        new Keyframe (1f, 1f, 1f, 1f)
                    }), 0f, false, new Vector2(0f, 1f));
                }
            }
        }
        else
        {
            m_tempSettings.blueCurve.overrideState = false;
        }

        //hueVsHueCurve
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.hueVsHueCurve.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.hueVsHueCurve.overrideState))
        {
            m_tempSettings.hueVsHueCurve.overrideState = true;

            if (t < 0.5f)
            {
                if (m_fromSettings != null)
                {
                    m_tempSettings.hueVsHueCurve.value = m_fromSettings.hueVsHueCurve.value;
                }
            }
            else
            {
                if (m_toSettings != null)
                {
                    m_tempSettings.hueVsHueCurve.value = m_toSettings.hueVsHueCurve.value;
                }
            }
        }
        else
        {
            m_tempSettings.hueVsHueCurve.overrideState = false;
        }

        //hueVsSatCurve
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.hueVsSatCurve.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.hueVsSatCurve.overrideState))
        {
            m_tempSettings.hueVsSatCurve.overrideState = true;

            if (t < 0.5f)
            {
                if (m_fromSettings != null)
                {
                    m_tempSettings.hueVsSatCurve.value = m_fromSettings.hueVsSatCurve.value;
                }
                else
                {
                    m_tempSettings.hueVsSatCurve.value = new Spline(new AnimationCurve(), 0.5f, true, new Vector2(0f, 1f));
                }
            }
            else
            {
                if (m_toSettings != null)
                {
                    m_tempSettings.hueVsSatCurve.value = m_toSettings.hueVsSatCurve.value;
                }
                else
                {
                    m_tempSettings.hueVsSatCurve.value = new Spline(new AnimationCurve(), 0.5f, true, new Vector2(0f, 1f));
                }
            }
        }
        else
        {
            m_tempSettings.hueVsSatCurve.overrideState = false;
        }

        //satVsSatCurve
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.satVsSatCurve.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.satVsSatCurve.overrideState))
        {
            m_tempSettings.satVsSatCurve.overrideState = true;

            if (t < 0.5f)
            {
                if (m_fromSettings != null)
                {
                    m_tempSettings.satVsSatCurve.value = m_fromSettings.satVsSatCurve.value;
                }
                else
                {
                    m_tempSettings.satVsSatCurve.value = new Spline(new AnimationCurve(), 0.5f, true, new Vector2(0f, 1f));
                }
            }
            else
            {
                if (m_toSettings != null)
                {
                    m_tempSettings.satVsSatCurve.value = m_toSettings.satVsSatCurve.value;
                }
                else
                {
                    m_tempSettings.satVsSatCurve.value = new Spline(new AnimationCurve(), 0.5f, true, new Vector2(0f, 1f));
                }
            }
        }
        else
        {
            m_tempSettings.satVsSatCurve.overrideState = false;
        }

        //lumVsSatCurve
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.lumVsSatCurve.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.lumVsSatCurve.overrideState))
        {
            m_tempSettings.lumVsSatCurve.overrideState = true;

            if (t < 0.5f)
            {
                if (m_fromSettings != null)
                {
                    m_tempSettings.lumVsSatCurve.value = m_fromSettings.lumVsSatCurve.value;
                }
                else
                {
                    m_tempSettings.lumVsSatCurve.value = new Spline(new AnimationCurve(), 0.5f, true, new Vector2(0f, 1f));
                }
            }
            else
            {
                if (m_toSettings != null)
                {
                    m_tempSettings.lumVsSatCurve.value = m_toSettings.lumVsSatCurve.value;
                }
                else
                {
                    m_tempSettings.lumVsSatCurve.value = new Spline(new AnimationCurve(), 0.5f, true, new Vector2(0f, 1f));
                }
            }
        }
        else
        {
            m_tempSettings.lumVsSatCurve.overrideState = false;
        }
    }
}