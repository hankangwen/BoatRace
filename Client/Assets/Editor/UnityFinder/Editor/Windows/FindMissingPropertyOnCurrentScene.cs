﻿using UnityEditor;
using UnityEngine;


namespace litefeel.Finder.Editor
{
    class FindMissingPropertyOnCurrentScene : FindWindowBase<Transform>
    {
        protected override void ConfigValues()
        {
            m_IgnoreScearchAssetType = true;
            m_IgnoreSearchAssetFolder = true;
        }
        protected override void DoFind()
        {
            m_Items.Clear();
            m_ItemNames.Clear();

            FindUtil.FilterCurrentStageOrScene(FindUtil.CheckMissingPropOnTransfrom, m_Items);

            foreach (var item in m_Items)
            {
                m_ItemNames.Add(UnityUtil.GetFullPath(item));
            }

            m_SimpleTreeView.Reload();
        }

        protected override bool InGameObjectAndChildren(GameObject prefab) { return false; }

        protected override void OnItemDoubleClick(int index)
        {
            Selection.activeTransform = m_Items[index];
        }

    }
}

