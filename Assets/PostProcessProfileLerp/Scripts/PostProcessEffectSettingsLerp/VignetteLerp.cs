﻿using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class VignetteLerp : PostProcessEffectSettingsLerp<Vignette>
{
    public VignetteMode defaultMode;
    public Color fromColor;
    public Color toColor;
    public Vector2 fromCenter;
    public Vector2 toCenter;
    public Vector2 intensity;
    public Vector2 smoothness;
    public Vector2 roundness;
    public bool defaultRounded;
    public Vector2 opacity;

    public VignetteLerp(PostProcessProfile from, PostProcessProfile to, PostProcessProfile temp) : base(from, to, temp)
    {
    }

    public override void InitializeParameters()
    {
        defaultMode = m_tempSettings.mode.value;

        //color
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.color.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.color.overrideState))
        {
            m_tempSettings.color.overrideState = true;
        }
        else
        {
            m_tempSettings.color.overrideState = false;
        }
        fromColor = m_fromSettings == null ? m_tempSettings.color.value : m_fromSettings.color.value;
        toColor = m_toSettings == null ? m_tempSettings.color.value : m_toSettings.color.value;

        //center
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.center.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.center.overrideState))
        {
            m_tempSettings.center.overrideState = true;
        }
        else
        {
            m_tempSettings.center.overrideState = false;
        }
        fromCenter = m_fromSettings == null ? m_tempSettings.center.value : m_fromSettings.center.value;
        toCenter = m_toSettings == null ? m_tempSettings.center.value : m_toSettings.center.value;

        //intensity
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.intensity.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.intensity.overrideState))
        {
            m_tempSettings.intensity.overrideState = true;
        }
        else
        {
            m_tempSettings.intensity.overrideState = false;
        }
        intensity.x = m_fromSettings == null ? m_tempSettings.intensity.value : m_fromSettings.intensity.value;
        intensity.y = m_toSettings == null ? m_tempSettings.intensity.value : m_toSettings.intensity.value;

        //smoothness
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.smoothness.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.smoothness.overrideState))
        {
            m_tempSettings.smoothness.overrideState = true;
        }
        else
        {
            m_tempSettings.smoothness.overrideState = false;
        }
        smoothness.x = m_fromSettings == null ? m_tempSettings.smoothness.value : m_fromSettings.smoothness.value;
        smoothness.y = m_toSettings == null ? m_tempSettings.smoothness.value : m_toSettings.smoothness.value;

        //roundness
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.roundness.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.roundness.overrideState))
        {
            m_tempSettings.roundness.overrideState = true;
        }
        else
        {
            m_tempSettings.roundness.overrideState = false;
        }
        roundness.x = m_fromSettings == null ? m_tempSettings.roundness.value : m_fromSettings.roundness.value;
        roundness.y = m_toSettings == null ? m_tempSettings.roundness.value : m_toSettings.roundness.value;

        defaultRounded = m_tempSettings.rounded.value;

        //opacity
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.opacity.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.opacity.overrideState))
        {
            m_tempSettings.opacity.overrideState = true;
        }
        else
        {
            m_tempSettings.opacity.overrideState = false;
        }
        opacity.x = m_fromSettings == null ? m_tempSettings.opacity.value : m_fromSettings.opacity.value;
        opacity.y = m_toSettings == null ? m_tempSettings.opacity.value : m_toSettings.opacity.value;
    }

    public override void Lerp(float t)
    {
        if (!IsValid())
        {
            return;
        }

        //mode
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.mode.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.mode.overrideState))
        {
            m_tempSettings.mode.overrideState = true;

            if (t < 0.5f)
            {
                if (m_fromSettings != null)
                {
                    m_tempSettings.mode.value = m_fromSettings.mode.value;
                }
                else
                {
                    m_tempSettings.mode.value = defaultMode;
                }
            }
            else
            {
                if (m_toSettings != null)
                {
                    m_tempSettings.mode.value = m_toSettings.mode.value;
                }
                else
                {
                    m_tempSettings.mode.value = defaultMode;
                }
            }
        }
        else
        {
            m_tempSettings.mode.overrideState = false;
        }

        m_tempSettings.color.value = Color.Lerp(fromColor, toColor, t);
        m_tempSettings.center.value = Vector2.Lerp(fromCenter, toCenter, t);
        m_tempSettings.intensity.value = Mathf.Lerp(intensity.x, intensity.y, t);
        m_tempSettings.smoothness.value = Mathf.Lerp(smoothness.x, smoothness.y, t);
        m_tempSettings.roundness.value = Mathf.Lerp(roundness.x, roundness.y, t);

        //rounded
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.rounded.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.rounded.overrideState))
        {
            m_tempSettings.rounded.overrideState = true;

            if (t < 0.5f)
            {
                if (m_fromSettings != null)
                {
                    m_tempSettings.rounded.value = m_fromSettings.rounded.value;
                }
                else
                {
                    m_tempSettings.rounded.value = defaultRounded;
                }
            }
            else
            {
                if (m_toSettings != null)
                {
                    m_tempSettings.rounded.value = m_toSettings.rounded.value;
                }
                else
                {
                    m_tempSettings.rounded.value = defaultRounded;
                }
            }
        }
        else
        {
            m_tempSettings.rounded.overrideState = false;
        }

        //mask
        if ((m_fromSettings != null && m_fromSettings.active && m_fromSettings.mask.overrideState) ||
            (m_toSettings != null && m_toSettings.active && m_toSettings.mask.overrideState))
        {
            m_tempSettings.mask.overrideState = true;

            if (t < 0.5f)
            {
                if (m_fromSettings != null)
                {
                    m_tempSettings.mask.value = m_fromSettings.mask.value;
                }
                else
                {
                    m_tempSettings.mask.value = null;
                }
            }
            else
            {
                if (m_toSettings != null)
                {
                    m_tempSettings.mask.value = m_toSettings.mask.value;
                }
                else
                {
                    m_tempSettings.mask.value = null;
                }
            }
        }
        else
        {
            m_tempSettings.mask.overrideState = false;
        }

        m_tempSettings.opacity.value = Mathf.Lerp(opacity.x, opacity.y, t);
    }
}