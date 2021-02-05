﻿using Assets.Scripts.UI.Menu;
using Photon;
using System.Collections.Generic;

namespace Assets.Scripts.UI
{
    public class UiMenu_PUN : PunBehaviour, IUiContainer
    {
        public virtual bool IsVisible() => gameObject.activeSelf;

        public virtual void Show() => gameObject.SetActive(true);

        public virtual void Hide() => gameObject.SetActive(false);

        protected List<IUiElement> children = new List<IUiElement>();

        public List<IUiElement> GetChildren() => children;

        public int GetNumVisibleChildren() => children.FindAll(e => e.IsVisible()).Count;

        public void AddChild(IUiElement element) => children.Add(element);

        public void RemoveChild(IUiElement element) => children.Remove(element);

        protected virtual void OnEnable()
        {
            MenuManager.RegisterOpened(this);
        }

        protected virtual void OnDisable()
        {
            MenuManager.RegisterClosed(this);
        }

    }
}
