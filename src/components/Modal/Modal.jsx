import React from 'react'


import { Background, Wrapper, IconClose } from './Modal-styles';

export default function Modal({ isOpen, setModalClose, children }) {
  if (!isOpen) return;
  
  return (
    <Background>
        <Wrapper>
          <IconClose>
            <span className="icon-close" onClick={setModalClose}>
              <ion-icon name="close"></ion-icon>
              </span>
          </IconClose>
          <div>{children}</div>
        </Wrapper>
    </Background>
  )
}
