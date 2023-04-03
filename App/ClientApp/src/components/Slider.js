import React, { useState, useEffect } from 'react';
import '../styles/Slider.css';
import { ImArrowLeft2, ImArrowRight2 } from 'react-icons/im';

const  Slider = ({ slides, autoSlideDelay = 5000 }) => {
    const [currentSlideIndex, setCurrentSlideIndex] = useState(0);
    const [isAutoSliding, setIsAutoSliding] = useState(true);
    const [isSliding, setIsSliding] = useState(false);

    useEffect(() => {
        let interval;
        if (isAutoSliding) {
            interval = setInterval(() => {
                setCurrentSlideIndex((currentSlideIndex + 1) % slides.length);
            }, autoSlideDelay);
        }

        return () => clearInterval(interval);
    }, [currentSlideIndex, isAutoSliding, slides.length, autoSlideDelay]);


    const handlePrevious = () => {
        setIsSliding(true);
        setTimeout(() => {
            setCurrentSlideIndex((currentSlideIndex - 1 + slides.length) % slides.length);
            setIsSliding(false);
            setIsAutoSliding(false);
        }, 500);
    };

    const handleNext = () => {
        setIsSliding(true);
        setTimeout(() => {
            setCurrentSlideIndex((currentSlideIndex + 1) % slides.length);
            setIsSliding(false);
            setIsAutoSliding(false);
        }, 500);
    };
    const handleSlideClick = (index) => {
        setCurrentSlideIndex(index);
        setIsAutoSliding(false);
    };

    const currentSlide = slides[currentSlideIndex];

    return (
        <div className="text-center slider-wrapper pt-5 mb-4">
            <h1 className="mb-4 slider-heading mx-auto text-light">Proč jet na Adapťák</h1>
            <div className="slider-container p-2">
                <button className="slider-button slider-button-left" onClick={handlePrevious}>
                    <ImArrowLeft2 color="#333" size={24} />
                </button>
                <div className="slider-content">
                    <h3 className="text-center pb-2">{currentSlide.heading}</h3>
                    <ul>
                        {currentSlide.listItems.map((item, index) => (
                            <li key={index}>{item}</li>
                        ))}
                    </ul>
                </div>
                <button className="slider-button slider-button-right" onClick={handleNext}>
                    <ImArrowRight2 color="#333" size={24} />
                </button>

            </div>
            <div className="slider-dots pb-4">
                {slides.map((slide, index) => (
                    <span
                        key={index}
                        className={`slider-dot ${currentSlideIndex === index ? 'active' : ''}`}
                        onClick={() => handleSlideClick(index)}
                    />
                ))}
            </div>
        </div>

    );
};

export default Slider;
