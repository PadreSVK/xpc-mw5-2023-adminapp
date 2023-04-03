import React, { useState } from 'react';
import { Container, Row, Col } from 'reactstrap';
import '../styles/Gallery.css'

const categories = [
    {
        name: 'Adaptak',
        images: [
            require('../images/adaptak_logo.png'),
            require('../images/adaptak_logo.png'),
            require('../images/adaptak_logo.png'),

        ],
    },
    {
        name: 'Vspj',
        images: [
            require('../images/vspj_logo.png'),
            require('../images/vspj_logo.png'),
            require('../images/vspj_logo.png'),
        ],
    },
    {
        name: 'Su',
        images: [
            require('../images/su_logo.png'),
            require('../images/su_logo.png'),
            require('../images/su_logo.png'),
        ],
    },
    // Add more categories as needed
];

export function Gallery() {
    const [selectedCategory, setSelectedCategory] = useState(categories[0]);

    function handleCategoryClick(category) {
        setSelectedCategory(category);
    }

    return (
        <Container className="full-height">
            <Row className="mt-4">
                <Col>
                    <nav>
                        {categories.map((category) => (
                            <button
                                key={category.name}
                                onClick={() => handleCategoryClick(category)}
                                className={category === selectedCategory ? 'active' : ''}
                            >
                                {category.name}
                            </button>
                        ))}
                    </nav>
                </Col>
            </Row>
            <Row>
                <Col>
                    <h2>{selectedCategory.name}</h2>
                    <div className="gallery">
                        {categories.map((category) => (
                            <div
                                key={category.name}
                                style={{
                                    display: category === selectedCategory ? 'flex' : 'none',
                                    flexWrap: 'wrap',
                                    justifyContent: 'space-evenly',
                                }}
                            >
                                {category.images.map((image) => (
                                    <img key={image} src={image} alt={category.name} className="gallery-image"/>
                                ))}
                            </div>
                        ))}
                    </div>
                </Col>
            </Row>
        </Container>
    );
}
