import React from "react";
import {ComponentPreview, Previews} from "@react-buddy/ide-toolbox";
import {PaletteTree} from "./palette";
import Carousel, {CarouselItem} from "../components/Carousel";

const ComponentPreviews = () => {
    return (
        <Previews palette={<PaletteTree/>}>
            <ComponentPreview path="/CarouselItem">
                <CarouselItem/>
            </ComponentPreview>
            <ComponentPreview path="/Carousel">
                <Carousel/>
            </ComponentPreview>
        </Previews>
    );
};

export default ComponentPreviews;